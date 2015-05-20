using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    class AspettoValutato
    {
        private readonly Aspetto _aspetto;
        private int _valutazione;

        public AspettoValutato(Aspetto aspetto, int valutazione)
        {
            // TODO: definire valore max e min parametrico per valutazione
            if (aspetto == null) // valutazione < 0 || valutazione > 10
                return; // throws ...
             
            this._aspetto = aspetto;
            this._valutazione = valutazione;
        }

        public Aspetto Aspetto
        {
            get { return _aspetto; }
        }

        public int Valutazione
        {
            get { return _valutazione; }
            set
            {
                // if (_valutazione < 0 || _valutazione > 10)
                //    return;

                _valutazione = value; 
            }
        }
    }
}
