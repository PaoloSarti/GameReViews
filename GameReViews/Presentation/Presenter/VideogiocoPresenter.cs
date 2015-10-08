using GameReViews.Model;
using GameReViews.Presentation.View;
using GameReViews.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    class VideogiocoPresenter
    {
        private VideogiocoRootView _view;
        private Sessione _sessione;
        private Videogioco _videogioco;

        public event EventHandler EliminaVideogioco;

        public VideogiocoPresenter(Videogioco videogioco, Sessione sessione)
        {
            this._videogioco = videogioco;
            this._sessione = sessione;
            this._view = new VideogiocoRootView(videogioco, BuildDetailView(videogioco));

            UpdateVideogiocoDetailView(videogioco);

            _sessione.Changed += UtenteCorrente_UtenteChanged;

            videogioco.Changed +=videogioco_VideogiocoChanged;

            if (videogioco.Recensione != null)
            {
                videogioco.Recensione.Changed += Recensione_RecensioneChanged;
            }

            _view.EliminaVideogioco += _rootView_EliminaVideogioco;

        }

        private void UpdateVideogiocoDetailView(Videogioco videogioco)
        {
            _view.UpdateVideogiocoView(BuildDetailView(videogioco));

            if (_sessione.UtenteCorrente != null && videogioco.Recensione == null)
                _view.abilitaEliminaButton(true);
            else
                _view.abilitaEliminaButton(false);
        }

        private UserControl BuildDetailView(Videogioco videogioco)
        {
            if (_videogioco.Recensione == null)
            {
                VideogiocoNoRecensioneView recensioneView = new VideogiocoNoRecensioneView();
                recensioneView.abilitaAggiuntaRecensione(_sessione.UtenteCorrente != null && _sessione.UtenteCorrente is Recensore);
                recensioneView.Dock = DockStyle.Fill;

                recensioneView.AggiuntaRecensione += _rootView_AggiuntaRecensione;

                return recensioneView;
            }
            else
            {
                VideogiocoRecensioneView recensioneView = new VideogiocoRecensioneView(_videogioco,
                    _sessione.CalcolaValutazioneTotale(_videogioco.Recensione));
                recensioneView.DisabilitaValutaAspettoButton((_sessione.UtenteCorrente == null)
                        || (_sessione.UtenteCorrente != null && _sessione.UtenteCorrente.Nome != _videogioco.Recensione.Autore.Nome));

                recensioneView.ValutaAspettoClick += _rootView_ValutaAspetto;

                recensioneView.GetCustomDataGrid().CellClicked += _rootView_ModificaValutazione;

                return recensioneView;
            }

        }

        void _rootView_EliminaVideogioco(object sender, EventArgs e)
        {

            try
            {
                Document.GetInstance().Videogiochi.RemoveVideogioco(_videogioco);

                if (EliminaVideogioco != null)
                    EliminaVideogioco(null, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void videogioco_VideogiocoChanged(object sender, EventArgs e)
        {
            _view.Videogioco = Videogioco;
            UpdateVideogiocoDetailView(Videogioco);

            if (Videogioco.Recensione != null)
            {
                Videogioco.Recensione.Changed -= Recensione_RecensioneChanged;
                Videogioco.Recensione.Changed += Recensione_RecensioneChanged;
            }
        }

        void Recensione_RecensioneChanged(object sender, EventArgs e)
        {
            _view.Videogioco = Videogioco;
            UpdateVideogiocoDetailView(Videogioco);
        }


        void _rootView_ModificaValutazione(object selectedObject)
        {
            if (_sessione.UtenteCorrente != null && _sessione.UtenteCorrente.Nome == _videogioco.Recensione.Autore.Nome)
            {
                AspettoValore aspettoValore = (AspettoValore)selectedObject;
                //Console.WriteLine(aspettoValore.Aspetto.Nome + " " +aspettoValore.Aspetto.Descrizione +" " +aspettoValore.Valore);

                ModificaEliminaValutazione dialog = new ModificaEliminaValutazione(aspettoValore);
                dialog.Titolo = "VALUTA ASPETTO";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (dialog.Elimina == true)
                        {
                            _videogioco.Recensione.RemoveAspettoValutato(aspettoValore.Aspetto);
                        }
                        else
                        {
                            _videogioco.Recensione.ModificaAspetto(aspettoValore.Aspetto, dialog.Valore);
                        }
                        //_rootView.Videogioco = Videogioco;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Impossibile modificare/eliminare la valutazione", "ERRORE",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        void _rootView_ValutaAspetto(object sender, EventArgs e)
        {
            if (_sessione.UtenteCorrente != null && _sessione.UtenteCorrente.Nome == _videogioco.Recensione.Autore.Nome)
            {
                List<Aspetto> aspettiList = (from aspettoValutato in Videogioco.Recensione.AspettiValutati select aspettoValutato.Aspetto).ToList();

                IEnumerable<Aspetto> aspetti = Document.GetInstance().Aspetti.List.Where(aspetto => !aspettiList.Contains(aspetto));

                AggiungiAspettoValore aggiungiAspettoValoreView = new AggiungiAspettoValore(aspetti);

                aggiungiAspettoValoreView.Titolo = "VALUTA ASPETTO";
                aggiungiAspettoValoreView.EnableEdit(true);

                if (aggiungiAspettoValoreView.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        string nome = aggiungiAspettoValoreView.Nome;
                        string descrizione = aggiungiAspettoValoreView.Descrizione;

                        Aspetto aspetto = new Aspetto(nome, descrizione);

                        int valutazione = aggiungiAspettoValoreView.Valutazione;

                        Videogioco.Recensione.AddAspettoValutato(aspetto, valutazione);

                        //_rootView.Videogioco = Videogioco;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Impossibile inserire l'aspetto", "ERRORE",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        void _rootView_AggiuntaRecensione(object sender, EventArgs e)
        {
            AggiungiRecensione dialog = new AggiungiRecensione();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string testo = dialog.Testo;

                    Recensione recensione = new Recensione(testo, (Recensore)_sessione.UtenteCorrente);

                    Videogioco.Recensione = recensione;

                    //_rootView.Videogioco = Videogioco;
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossibile modificare/eliminare la preferenza", "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        void UtenteCorrente_UtenteChanged(object sender, EventArgs e)
        {
            //reinvoco la set del videogioco che scatena il refresh
            this.Videogioco = _videogioco;
        }

        public Control View
        {
            get
            {
                return _view;
            }
        }

        public Videogioco Videogioco
        {
            get { return _videogioco; }
            set
            {
                if (_videogioco != null)
                    _videogioco.Changed -= videogioco_VideogiocoChanged;
                _videogioco = value;

                _view.Videogioco = _videogioco;
                UpdateVideogiocoDetailView(Videogioco);

                _videogioco.Changed += videogioco_VideogiocoChanged;
                videogioco_VideogiocoChanged(null, EventArgs.Empty);
            }
        }
    }
}
