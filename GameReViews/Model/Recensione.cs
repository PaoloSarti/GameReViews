using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    public class Recensione
    {
        private string _testo;
        private readonly DateTime _dataImmissione;

        private readonly Recensore _autore;
        private readonly AspettiValutati _aspettiValutati;

        private readonly List<Commento> _commenti;

        public event EventHandler Changed;

        public Recensione(string testo, Recensore autore)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(testo)||autore==null)
                throw new ArgumentException("videogioco == null || String.IsNullOrEmpty(testo)||autore==null");
            #endregion         

            this._testo = testo;
            this._autore = autore;
            this._dataImmissione = DateTime.Now;
            _aspettiValutati = new AspettiValutati();

            this._commenti = new List<Commento>();
        }

        public DateTime DataImmissione
        {
            get { return _dataImmissione; }
        }

        public string Testo
        {
            get { return _testo; }

            set 
            {
                #region Precondizioni
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("String.IsNullOrEmpty(value)");
                #endregion

                _testo = value;
                OnRecensioneChanged();
            }
        }

        public Recensore Autore
        {
            get { return _autore; }
        }

        public IEnumerable<Commento> Commenti
        {
            get { return _commenti; }
        } 

        public IEnumerable<AspettoValutato> AspettiValutati
        {
            get
            {
                return _aspettiValutati.List;
            }
        }

        public void AddAspettoValutato(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            if (!AspettiValori<AspettoValore>.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _aspettiValutati.Add(aspetto, valutazione);

            OnRecensioneChanged();
        }

        public void RemoveAspettoValutato(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            #endregion

            _aspettiValutati.Remove(aspetto);

            OnRecensioneChanged();
        }

        public void RemoveAllAspettiValutati()
        {
            _aspettiValutati.RemoveAll();
        }

        public void ModificaAspetto(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            if (!AspettiValori<AspettoValutato>.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _aspettiValutati.ModificaValutazione(aspetto, valutazione);

            OnRecensioneChanged();
        }

        //Inserimento alla radice (lista di commenti della recensione)
        public void InserisciCommento(String testo, UtenteRegistrato autore)
        {
            Commento child = new Commento(testo, autore);

            _commenti.Add(child);

            OnRecensioneChanged();
        }

        protected void OnRecensioneChanged()
        {
            if (Changed != null)
            {
                Changed(null, EventArgs.Empty);
            }
        }
    }
}
