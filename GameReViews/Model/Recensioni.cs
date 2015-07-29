using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{

    /* 
     * Classe contenitore per le recensioni presenti nel sistema,
     * aggiorna il riferimento alla recensione del videogioco recensito sia in caso di aggiunta che in caso di rimozione
     */
    public class Recensioni
    {
        private readonly HashSet<Recensione> _recensioniSet;

        public event EventHandler RecensioniChanged;

        public Recensioni()
        {
            _recensioniSet = new HashSet<Recensione>();
        }

        public IEnumerable<Recensione> List
        {
            get { return _recensioniSet; }
        }

        public void AddRecensione(Recensione recensione)
        {
            #region Precondizioni
            if (recensione == null)
                throw new ArgumentNullException("recensione == null");
            #endregion

            if ( !_recensioniSet.Add(recensione) )
                throw new InvalidOperationException("!_recensioniSet.Add(recensione)");

            OnChanged();
        }
        
        public void RemoveRecensione(Recensione recensione)
        {
            #region Precondizioni
            if (recensione == null)
                throw new ArgumentException("recensione == null");
            #endregion

            if (_recensioniSet.Remove(recensione))
                recensione.Videogioco.Recensione = null;
            else
                throw new ArgumentException("_recensioneSet.Remove(recensione)");

            OnChanged();
        }

        protected void OnChanged()
        {
            if (RecensioniChanged != null)
            {
                RecensioniChanged(null, EventArgs.Empty);
            }
        }
    }
}
