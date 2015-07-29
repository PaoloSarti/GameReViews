using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Model
    {
        private static Model _instance;

        //per avere una funzione Load(), non possono essere readonly, tuttavia, possono essere 
        //acceduti solo in lettura al di fuori del Model
        private Aspetti _aspetti;
        private UtentiRegistrati _utenti;
        private Recensioni _recensioni;
        private Videogiochi _videogiochi;

        //Evento scatenato da Load di tutto,
        //potrebbe non essere necessario
        public event EventHandler Loaded;

        public static Model GetInstance()
        {
            if (_instance == null) 
            {
                _instance = new Model();
                return _instance;
            }
            else
                return _instance;
        }

        private Model()
        {
            _aspetti = new Aspetti();
            _utenti = new UtentiRegistrati();
            _recensioni = new Recensioni();
            _videogiochi = new Videogiochi();
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
            this._videogiochi = loader.LoadVideogiochi();
            this._utenti = loader.LoadUtentiRegistrati();
            this._recensioni = loader.LoadRecensioni();

            OnLoaded();
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

        public UtentiRegistrati Utenti
        {
            get { return _utenti; }
        }

        public Recensioni Recensioni
        {
            get { return _recensioni; }
        }

        public Videogiochi Videogiochi
        {
            get { return _videogiochi; }
        }
        #endregion


        //#region Liste
        //public IEnumerable<Videogioco> GetVideogiochi()
        //{
        //    return _videogiochi.List;
        //}

        //public IEnumerable<Recensione> GetRecensioni()
        //{
        //    return _recensioni.List;
        //}

        //public IEnumerable<UtenteRegistrato> GetUtenti()
        //{
        //    return _utenti.List;
        //}

        //public IEnumerable<Recensore> GetRecensori()
        //{
        //    return _utenti.List.OfType<Recensore>();
        //}

        //public IEnumerable<Aspetto> GetAspetti()
        //{
        //    return _aspetti.List;
        //}
        //#endregion


        //#region Metodi Pubblici
        ////Il model agisce da Facade raccogliendo i metodi delle classi contenitore da presentare all'esterno        
        //public void Registra(UtenteRegistrato utente)
        //{
        //    this._utenti.Registra(utente);
        //    OnChanged();
        //}

        //public UtenteRegistrato Autentica(String nome, String password)
        //{
        //    return this._utenti.Autentica(nome, password);
        //}

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


        protected virtual void OnLoaded()
        {
            if (Loaded != null)
                Loaded(this, EventArgs.Empty);
        }
    }
}
