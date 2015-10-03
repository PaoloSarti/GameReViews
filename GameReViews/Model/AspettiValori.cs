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

        protected HashSet<T> _aspettiValori;
        protected static readonly HashSet<T> _emptyAspettiValori = new HashSet<T>();

        public AspettiValori()
        {
            _aspettiValori = _emptyAspettiValori;
        }

        public abstract void Add(T a);

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

    }
}
