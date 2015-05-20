using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    // lanciamo sempre eccezioni o diamo ad alcuni metodi valori di ritorno bool per distriminare successo da fallimento?
    public class AspettiValutatiManager
    {
        private Dictionary<Aspetto, int> _aspettiValutati;
        private static readonly Dictionary<Aspetto, int> _emptyAspettiValutati = new Dictionary<Aspetto, int>();

        public AspettiValutatiManager()
        {
            _aspettiValutati = _emptyAspettiValutati;
        }

        public IEnumerable<AspettoValutato> AspettiValutati
        {
            get
            {
                // funzionerà ??
                return (from aspetto in _aspettiValutati.Keys select new AspettoValutato(aspetto, _aspettiValutati[aspetto]));
            }
        }

        public void AddAspettoValutato(AspettoValutato aspettoValutato)
        {
            if (aspettoValutato == null)
                return;

            if (this._aspettiValutati == _emptyAspettiValutati)
                this._aspettiValutati = new Dictionary<Aspetto, int>();

            this._aspettiValutati.Add(aspettoValutato.Aspetto, aspettoValutato.Valutazione);
        }

        public void RemoveAspettoValutato(Aspetto aspetto)
        {
            if (aspetto == null)
                return;

            if (this._aspettiValutati == _emptyAspettiValutati)
                return;

            if (this._aspettiValutati.ContainsKey(aspetto))
                this._aspettiValutati.Remove(aspetto);
        }

        public void ModificaValutazioneAspetto(Aspetto aspetto, int valutazione)
        {
            // TODO: creare valori parametrici per valore max e min di valutazione

            if (aspetto == null) // || valutazione < 0 || valutazione > 10 )
                return;

            if (this._aspettiValutati == _emptyAspettiValutati)
                return;

            if (this._aspettiValutati.ContainsKey(aspetto))
                this._aspettiValutati[aspetto] = valutazione;
        }
    }
}
