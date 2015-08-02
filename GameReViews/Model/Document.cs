using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Document
    {
        private static Document _instance;

        //per avere una funzione Load(), non possono essere readonly, tuttavia, possono essere 
        //acceduti solo in lettura al di fuori del Model
        private Aspetti _aspetti;
        private UtentiRegistrati _utenti;
        private Recensioni _recensioni;
        private Videogiochi _videogiochi;

        private UtenteRegistrato _utenteCorrente;
        private ICalcoloValutazioneTotale _calcolo;

        //Evento scatenato da modifiche al livello dell'intero Document,
        //come modifiche all'utente corrente, o caricamento dei dati
        public event EventHandler Changed;

        public static Document GetInstance()
        {
            if (_instance == null) 
            {
                _instance = new Document();
                return _instance;
            }
            else
                return _instance;
        }

        private Document()
        {
            _aspetti = new Aspetti();

            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();

            //si prendono i riferimenti dal loader
            //_utenti = new UtentiRegistrati();
            //_recensioni = new Recensioni();
            //_videogiochi = new Videogiochi();
        }

        #region Persistenza

        public void Load(IModelPersister persister)
        {
            #region Precondizioni
            if (persister == null)
                throw new ArgumentNullException("persister == null");
            #endregion

            IModelLoader loader = persister.GetLoader();

            //gli aspetti vengono popolati automaticamente utilizando i metodi di AspettiValori e figli (AspettiValutati e Preferenze)
            this._videogiochi = loader.GetVideogiochi();
            this._utenti = loader.GetUtentiRegistrati();
            this._recensioni = loader.GetRecensioni();

            OnChanged();
        }

        public void Save(IModelPersister persister)
        {
            #region Precondizioni
            if (persister == null)
                throw new ArgumentNullException("persister == null");
            #endregion

            persister.Save(this);
        }
        #endregion

        #region Proprietà Classi Contenitore
        //Proprietà "readonly" per accedere alle classi contenitore 
        //in cui sono raggruppate le operazioni pubbliche
        public Aspetti Aspetti
        {
            get { return _aspetti; }
        }

        //per questa classe metto i metodi di Login e Registrazione 
        //public UtentiRegistrati Utenti
        //{
        //    get { return _utenti; }
        //}

        public Recensioni Recensioni
        {
            get { return _recensioni; }
        }

        public Videogiochi Videogiochi
        {
            get { return _videogiochi; }
        }
        #endregion

        #region utente

        public void Registra(String nome, String password)
        {
            UtenteRegistrato utente = new UtenteRegistrato(nome, password);
            this._utenti.Registra(utente);
            _utenteCorrente = utente;
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(utente);
            OnChanged();
        }

        public UtenteRegistrato UtenteCorrente
        {
          get { return _utenteCorrente; }
        }

        public UtenteRegistrato Autentica(String nome, String password)
        {
            _utenteCorrente = _utenti.Autentica(nome, password);
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale(_utenteCorrente);
            OnChanged();

            return _utenteCorrente;
        }

        public void Logout()
        {
            _utenteCorrente=null;
            _calcolo = CalcoloValutazioneTotaleFactory.GetCalcoloValutazioneTotale();
            OnChanged();
        }
        #endregion

        public ICalcoloValutazioneTotale Calcolo
        {
            get { return _calcolo; }
        }

        //#region Metodi Pubblici
        ////Il model agisce da Facade raccogliendo i metodi delle classi contenitore da presentare all'esterno        

        //public void AddVideogioco(Videogioco videogioco)
        //{
        //    this._videogiochi.AddVideogioco(videogioco);
        //    OnChanged();
        //}

        //public void RemoveVideogioco(Videogioco videogioco)
        //{
        //    this._videogiochi.RemoveVideogioco(videogioco);
        //    OnChanged();
        //}

        //public void AddRecensione(Recensione recensione)
        //{
        //    this._recensioni.AddRecensione(recensione);
        //    OnChanged();
        //}

        //public void RemoveRecensione(Recensione recensione)
        //{
        //    this._recensioni.RemoveRecensione(recensione);
        //    OnChanged();
        //}

        //#endregion


        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
    }
}
