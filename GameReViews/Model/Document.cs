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

        private Videogiochi _videogiochi;

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

        public Videogiochi Videogiochi
        {
            get { return _videogiochi; }
        }


        public UtentiRegistrati Utenti
        {
            get { return _utenti; }
        }

        #endregion



        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
    }
}
