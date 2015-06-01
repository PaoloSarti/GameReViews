using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensione
    {
        private readonly Videogioco _videogioco;
        private readonly DateTime _dataImmissione;
        private string _testo;

        private AspettiValutati _aspettiValutati;

        public Recensione(Videogioco videogioco, string testo)
        {
            #region Precondizioni
            if (videogioco == null || String.IsNullOrEmpty(testo))
                throw new ArgumentException("videogioco == null || String.IsNullOrEmpty(testo)");
            #endregion         

            this._videogioco = videogioco;
            this._testo = testo;

            this._dataImmissione = DateTime.Now;
            this._videogioco.Recensione = this;
            _aspettiValutati = new AspettiValutati();
        }

        public Videogioco Videogioco
        {
            get { return _videogioco; }
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
            }
        }

        public IEnumerable<KeyValuePair<Aspetto, int>> GetAspettiValutati()
        {
            return _aspettiValutati.AspettiValutati;
        }

        public void AddAspettoValutato(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _aspettiValutati.Add(aspetto, valutazione);
        }

        public void RemoveAspettoValutato(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            #endregion

            _aspettiValutati.Remove(aspetto);
        }

        public void ModificaAspetto(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _aspettiValutati.ModificaValutazione(aspetto, valutazione);
        }
    }
}
