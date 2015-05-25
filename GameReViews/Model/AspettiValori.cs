using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    // lanciamo sempre eccezioni o diamo ad alcuni metodi valori di ritorno bool per distriminare successo da fallimento?
    public abstract class AspettiValori
    {
        private Dictionary<Aspetto, int> _aspettiValori;
        private static readonly Dictionary<Aspetto, int> _emptyAspettiValori = new Dictionary<Aspetto, int>();

        public AspettiValori()
        {
            _aspettiValori = _emptyAspettiValori;
        }

        public abstract void Add(Aspetto aspetto, int value);

        public IEnumerable<KeyValuePair<Aspetto, int>> AspettiValutati
        {
            get
            {
                // funzionerà ????
                return (from aspetto in _aspettiValori select aspetto);
            }
        }

        public void RemoveAspetto(Aspetto aspetto)
        {
            // TODO update reference counting 

            if (aspetto == null)
                return;

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            if (this._aspettiValori.ContainsKey(aspetto))
                this._aspettiValori.Remove(aspetto);
        }

        public void ModificaValutazione(Aspetto aspetto, int valutazione)
        {
            // TODO: creare valori parametrici per valore max e min di valutazione

            if (aspetto == null) // || valutazione < 0 || valutazione > 10 )
                return;

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            if (this._aspettiValori.ContainsKey(aspetto))
                this._aspettiValori[aspetto] = valutazione;
        }
    }
}
