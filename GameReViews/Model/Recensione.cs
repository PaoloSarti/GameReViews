using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    public class Recensione
    {
        private string _testo;

        private readonly Recensore _autore;
        private readonly AspettiValutati _aspettiValutati;

        public event EventHandler Changed;

        public Recensione(string testo, Recensore autore)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(testo)||autore==null)
                throw new ArgumentException("videogioco == null || String.IsNullOrEmpty(testo)||autore==null");
            #endregion         

            this._testo = testo;
            this._autore = autore;
            _aspettiValutati = new AspettiValutati();
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
            #endregion

            _aspettiValutati.Add(new AspettoValutato(aspetto, valutazione));

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

            #endregion

            _aspettiValutati.ModificaValutazione(aspetto, valutazione);

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
