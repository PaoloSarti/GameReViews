using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    /*
     * La sessione mantiene le informazioni legate ad una interazione col sistema,
     * mantenendo quindi il riferimento all'UtenteRegistrato corrente (null se non presente),
     * e in ogni caso mantiene l'algoritmo di calcolo specifico per la sessione, fornendo
     * la funzione di calcolo della valutazione totale.
     */ 
    public class Sessione
    {
        private UtenteRegistrato _utenteCorrente;
        private ICalcoloValutazioneTotale _calcolo;

        public event EventHandler Changed;

        public Sessione()
        {
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();
        }

        #region Calcolo

        public float CalcolaValutazioneTotale(Recensione recensione)
        {
            return _calcolo.Calcola(recensione);
        }

        #endregion

        #region utente

        public UtenteRegistrato UtenteCorrente
        {
            get { return _utenteCorrente; }
        }

        public void Registra(String nome, String password)
        {
            UtenteRegistrato utente = new UtenteRegistrato(nome, password);
            Document.GetInstance().Autenticatore.Registra(utente);
            _utenteCorrente = utente;
            _utenteCorrente.Changed += UtenteChanged;

            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(utente);

            OnChange();
        }

        public UtenteRegistrato Autentica(String nome, String password)
        {
            _utenteCorrente = Document.GetInstance().Autenticatore.Autentica(nome, password);
            _utenteCorrente.Changed += UtenteChanged;

            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(_utenteCorrente);

            OnChange();

            return _utenteCorrente;
        }

        public void Logout()
        {
            _utenteCorrente.Changed -= UtenteChanged;
            _utenteCorrente = null;
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();

            OnChange();
        }

        private void OnChange()
        {
            if (Changed != null)
                Changed(null, EventArgs.Empty);
        }

        private void UtenteChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        #endregion
    }
}
