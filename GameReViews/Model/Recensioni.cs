using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensioni
    {
        private readonly HashSet<Recensione> _recensioniSet;

        public Recensioni()
        {
            _recensioniSet = new HashSet<Recensione>();
        }

        public IEnumerable<Recensione> RecensioniSet
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
        }
    }
}
