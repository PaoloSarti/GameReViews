using System;

namespace GameReViews.Model
{
    public class Document
    {
        private static Document _instance;

        // per avere una funzione Load(), non possono essere readonly, tuttavia, possono essere 
        // acceduti solo in lettura al di fuori del Model
        private Aspetti _aspetti;
        private IAutenticatore _autenticatore;

        private Videogiochi _videogiochi;

        // Evento scatenato da modifiche al livello dell'intero Document,
        // come modifiche all'utente corrente, o caricamento dei dati
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
        }

        #region Persistenza

        public void Load(IModelPersister persister)
        {
            #region Precondizioni
            if (persister == null)
                throw new ArgumentNullException("persister == null");
            #endregion

            IModelLoader loader = persister.GetLoader();

            // gli aspetti vengono popolati automaticamente utilizando i metodi di AspettiValori e figli (AspettiValutati e Preferenze)
            this._videogiochi = loader.GetVideogiochi();
            this._autenticatore = loader.GetIAutenticatore();

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

        // Proprietà "readonly" per accedere alle classi contenitore 
        // in cui sono raggruppate le operazioni pubbliche
        public Aspetti Aspetti
        {
            get { return _aspetti; }
        }

        public Videogiochi Videogiochi
        {
            get { return _videogiochi; }
        }

        public IAutenticatore Autenticatore
        {
            get { return _autenticatore; }
        }

        #endregion

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
    }
}
