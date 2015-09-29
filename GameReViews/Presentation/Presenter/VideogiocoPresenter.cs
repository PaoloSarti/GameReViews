using GameReViews.Model;
using GameReViews.Presentation.View;
using GameReViews.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            this._view = new VideogiocoRootView(videogioco, sessione);
            this._sessione = sessione;

            _view.AggiuntaRecensione += _rootView_AggiuntaRecensione;

            _sessione.SessionChanged += UtenteCorrente_UtenteChanged;

            _view.ValutaAspetto += _rootView_ValutaAspetto;

            _view.ModificaValutazione += _rootView_ModificaValutazione;

            videogioco.VideogiocoChanged +=videogioco_VideogiocoChanged;

            if (videogioco.Recensione != null)
            {
                videogioco.Recensione.RecensioneChanged += Recensione_RecensioneChanged;
            }

            _view.EliminaVideogioco += _rootView_EliminaVideogioco;

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
            if (Videogioco.Recensione != null)
            {
                Videogioco.Recensione.RecensioneChanged += Recensione_RecensioneChanged;
            }
        }

        void Recensione_RecensioneChanged(object sender, EventArgs e)
        {
            _view.Videogioco = Videogioco;
        }


        void _rootView_ModificaValutazione(object selectedObject)
        {
            AspettoValore aspettoValore = (AspettoValore)selectedObject;
            //Console.WriteLine(aspettoValore.Aspetto.Nome + " " +aspettoValore.Aspetto.Descrizione +" " +aspettoValore.Valore);

            ModificaEliminaValutazioneView dialog = new ModificaEliminaValutazioneView(aspettoValore);
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

        void _rootView_ValutaAspetto(object sender, EventArgs e)
        {
            List<Aspetto> aspettiList = (from aspettoValutato in Videogioco.Recensione.AspettiValutati.List select aspettoValutato.Aspetto).ToList();

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
                    _videogioco.VideogiocoChanged -= videogioco_VideogiocoChanged;
                _videogioco = value;
                _view.Videogioco = _videogioco;
                _videogioco.VideogiocoChanged += videogioco_VideogiocoChanged;
            }
        }






    }
}
