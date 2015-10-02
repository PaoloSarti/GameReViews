using System;
using System.Collections.Generic;

namespace GameReViews.Model
{


    /*
     * Classe che fattorizza la interazione tra Preferenze (degli UtentiRegistrati) e AspettiValutati (nelle Recensioni)
     * con la classe che mantiene gli Aspetti correntemente utilizzati nel sistema.
     * Questa classe implementa le azioni di rimozione e modifica della valutazione,
     * lasciando astratta la aggiunta.
     */
    public abstract class AspettiValori<T> where T : AspettoValore
    {
        // vedi requisiti non funzionali del progetto
        private readonly static int valoreMinimo = 0;
        private readonly static int valoreMassimo = 10;

        protected List<T> _aspettiValori;
        protected static readonly List<T> _emptyAspettiValori = new List<T>();

        public AspettiValori()
        {
            _aspettiValori = _emptyAspettiValori;
        }

        public abstract void Add(Aspetto aspetto, int value);

        public IEnumerable<T> List
        {
            get
            {
                return _aspettiValori;
            }
        }

        public void Remove(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            // controllo se l'aspetto è presente nella lista
            // se lo trovo lo e elimino e aggiorno il reference counting
            T item = null;
            foreach (T aspettoValore in _aspettiValori)
                if (aspettoValore.Aspetto.Equals(aspetto))
                {
                    item = aspettoValore;
                    _aspettiValori.Remove(item);
                    Document.GetInstance().Aspetti.Remove(aspetto);
                    break;
                }
        }

        public void RemoveAll()
        {
            if (this._aspettiValori == _emptyAspettiValori)
                return;

            foreach(T a in _aspettiValori)
            {
                this.Remove(a.Aspetto);
            }
        }

        public void ModificaValutazione(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori<T>.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            #endregion

            if (this._aspettiValori == _emptyAspettiValori)
                return;

            // controllo se l'aspetto è presente nella lista
            // se c'è lo aggiorno
            foreach (T aspettoValore in _aspettiValori)
                if (aspettoValore.Aspetto.Equals(aspetto)) {
                    aspettoValore.Valore = valutazione;
                    break;
                }
        }

        public static int ValoreMinimo
        {
            get { return AspettiValori<T>.valoreMinimo; }
        }

        public static int ValoreMassimo
        {
            get { return AspettiValori<T>.valoreMassimo; }
        }

        public static Boolean IsValueValid(int value)
        {
            bool res = false;

            if (value >= ValoreMinimo && value <= ValoreMassimo)
                res = true;

            return res;
        }
    }
}
