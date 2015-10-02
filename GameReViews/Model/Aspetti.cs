using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{ 
    public class Aspetti
    {
        private readonly Dictionary<Aspetto, int> _aspettiReferenceCount;

        public Aspetti()
        {
            _aspettiReferenceCount = new Dictionary<Aspetto, int>();
        }

        // inserisce un aspetto nel dizionario. 
        // se non è gia presente lo aggiunge con contatore = 1
        // se è gia presente incrementa il suo contatore di 1
        public void Add(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            if (_aspettiReferenceCount.ContainsKey(aspetto))
                _aspettiReferenceCount[aspetto]++;
            else
                _aspettiReferenceCount.Add(aspetto, 1);
        }

        public void Remove(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            if (_aspettiReferenceCount.ContainsKey(aspetto))
                _aspettiReferenceCount[aspetto]--;
            else
                throw new ArgumentException("_aspettiReferenceCount.ContainsKey(aspetto)");

            if (_aspettiReferenceCount[aspetto] <= 0)
                _aspettiReferenceCount.Remove(aspetto);
        }

        public IEnumerable<Aspetto> List
        {
            get { return _aspettiReferenceCount.Keys; }
        }

        public bool Contains(Aspetto aspetto)
        {
            return _aspettiReferenceCount.ContainsKey(aspetto);
        }
    }
}
