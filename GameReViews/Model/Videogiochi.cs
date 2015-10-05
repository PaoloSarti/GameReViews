using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // Classe contenitore per i videogiochi presenti nel sistema,
    // in particolare controlla che non sia rimosso un videogioco a cui è associata una recensione
    public class Videogiochi
    {
        private readonly HashSet<Videogioco> _videogiochiSet;

        public event EventHandler Changed;

        public Videogiochi()
        {
            _videogiochiSet = new HashSet<Videogioco>();
        }

        public IEnumerable<Videogioco> List
        {
            get { return _videogiochiSet; }
        }

        public IEnumerable<Videogioco> VideogiochiRecensiti
        {
            get
            {
                return _videogiochiSet.Where(videogioco => (videogioco.Recensione != null));
            }
        }

        public IEnumerable<Recensione> Recensioni
        {
            get
            {
                return from videogioco in _videogiochiSet select videogioco.Recensione;
            }
        }


        public Videogioco GetVideogioco(string nome)
        {
            foreach (Videogioco v in _videogiochiSet)
                if (v.Nome == nome)
                    return v;

            throw new ArgumentException("videogioco non trovato");
        }

        public void AddVideogioco(Videogioco videogioco)
        {
            #region Precondizioni
            if (videogioco == null)
                throw new ArgumentException("videogioco == null");
            #endregion

            bool success = _videogiochiSet.Add(videogioco);

            if (!success)
                throw new InvalidOperationException("Videogioco già presente nel sistema");

            OnChanged();
        }

        public void RemoveVideogioco(Videogioco videogioco)
        {
            #region Precondizioni
            if (videogioco == null)
                throw new ArgumentException("videogioco == null");
            
            // non si può eliminare un videogioco a cui è associata una recensione
            if (videogioco.Recensione != null)
                throw new InvalidOperationException("videogioco.Recensione != null");
            #endregion

            if (!_videogiochiSet.Remove(videogioco))
                throw new ArgumentException("!_videogiochiSet.Remove(videogioco)");

            OnChanged();
        }

        protected void OnChanged()
        {
            if(Changed!=null)
            {
                Changed(null, EventArgs.Empty);
            }
        }
    }
}
