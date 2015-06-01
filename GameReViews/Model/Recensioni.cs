using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensioni
    {
        private readonly HashSet<Recensione> _recensioneSet;

        public Recensioni()
        {
            _recensioneSet = new HashSet<Recensione>();
        }

        public IEnumerable<Recensione> RecensioniList
        {
            get { return _recensioneSet; }
        }

        public void AddRecensione(Recensione recensione)
        {
            bool success = _recensioneSet.Add(recensione);

            if (!success)
                throw new InvalidOperationException("!success");
        }
        
        public void RemoveRecensione(Recensione recensione)
        {
            if (!_recensioneSet.Contains(recensione))
                throw new InvalidOperationException("!_recensioneSet.Contains(recensione)");
            else
            {
                GetRecensione(recensione).Videogioco.Recensione = null;
                _recensioneSet.Remove(recensione);
            }
        }

        public Recensione GetRecensione(Recensione recensione)
        {
            foreach (Recensione v in _recensioneSet)
            {
                if (v.Equals(recensione))
                    return v;
            }

            return null;
        }

    }
}
