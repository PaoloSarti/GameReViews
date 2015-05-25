using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO checks
    public class Videogiochi
    {
        private readonly HashSet<Videogioco> _videogiochiSet;

        public Videogiochi()
        {
            _videogiochiSet = new HashSet<Videogioco>();
        }

        public IEnumerable<Videogioco> VideogiochiList
        {
            get { return _videogiochiSet; }
        }

        public void AddVideogioco(Videogioco videogioco)
        {
            bool success = _videogiochiSet.Add(videogioco);

            if (!success)
                throw new InvalidOperationException("Videogioco già presente nel sistema");
        }

        // non funziona. vedi equals di videioioco
        public void RemoveVideogioco(Videogioco videogioco)
        {
            // TODO exception if null

            if (!_videogiochiSet.Contains(videogioco))
                throw new InvalidOperationException("!_videogiochiSet.Contains(videogioco)");
            else if(GetVideogioco(videogioco).Recensione != null)
                throw new InvalidOperationException("GetVideogioco(videogioco).Recensione != null");
            else
                _videogiochiSet.Remove(videogioco);
        }

        public Videogioco GetVideogioco(Videogioco videogioco)
        {
            foreach (Videogioco v in _videogiochiSet)
            {
                if(v.Equals(videogioco))
                    return v;
            }

            return null;
        }
    }
}
