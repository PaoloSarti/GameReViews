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
        private VideogiocoRootView _rootView;
        private Sessione _sessione;
        private Videogioco _videogioco;

        public VideogiocoPresenter(Videogioco videogioco, Sessione sessione)
        {
            this._videogioco = videogioco;
            this._rootView = new VideogiocoRootView(videogioco, sessione);
            this._sessione = sessione;

            _rootView.AggiuntaRecensione += _rootView_AggiuntaRecensione;

            _sessione.SessionChanged += UtenteCorrente_UtenteChanged;

            _rootView.ValutaAspetto += _rootView_ValutaAspetto;

            _rootView.ModificaValutazione += _rootView_ModificaValutazione;
        }

        void _rootView_ModificaValutazione(object selectedObject)
        {
            AspettoValore aspettoValore = (AspettoValore)selectedObject;
            //Console.WriteLine(aspettoValore.Aspetto.Nome + " " +aspettoValore.Aspetto.Descrizione +" " +aspettoValore.Valore);

            ModificaEliminaValutazioneView dialog = new ModificaEliminaValutazioneView(aspettoValore);

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
                    _rootView.Videogioco = Videogioco;
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

            aggiungiAspettoValoreView.Titolo = "Valuta aspetto";
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

                    _rootView.Videogioco = Videogioco;
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

                    _rootView.Videogioco = Videogioco;
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

        public VideogiocoRootView View
        {
            get
            {
                return _rootView;
            }
        }

        public Videogioco Videogioco
        {
            get { return _videogioco; }
            set
            {
                _videogioco = value;
                _rootView.Videogioco = value;
            }
        }






    }
}
