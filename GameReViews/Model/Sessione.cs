using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{

    public class Sessione
    {

        public event EventHandler SessionChanged;

        private UtenteRegistrato _utenteCorrente;
        private ICalcoloValutazioneTotale _calcolo;

        public Sessione()
        {
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();
        }

        #region utente

        public void Registra(String nome, String password)
        {
            UtenteRegistrato utente = new UtenteRegistrato(nome, password);
            Document.GetInstance().Utenti.Registra(utente);
            _utenteCorrente = utente;
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(utente);

            OnChange();
        }

        public UtenteRegistrato UtenteCorrente
        {
            get { return _utenteCorrente; }
        }

        public UtenteRegistrato Autentica(String nome, String password)
        {
            _utenteCorrente = Document.GetInstance().Utenti.Autentica(nome, password);
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(_utenteCorrente);

            OnChange();

            return _utenteCorrente;
        }

        public void Logout()
        {
            _utenteCorrente = null;
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();

            OnChange();
        }

        private void OnChange()
        {
            if (SessionChanged != null)
                SessionChanged(null, EventArgs.Empty);
        }


        #endregion

        #region Calcolo

        public ICalcoloValutazioneTotale Calcolo
        {
            get { return _calcolo; }
        }

        #endregion

    }
}
