using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensione
    {
        private readonly Recensore _autore;
        private readonly Videogioco _videogioco;
        private readonly DateTime _dataImmissione;
        private string _testo;
        private readonly List<Commento> _commenti;
        private AspettiValutati _aspettiValutati;

        public event EventHandler RecensioneChanged;

        public Recensione(Videogioco videogioco, string testo, Recensore autore)
        {
            #region Precondizioni
            if (videogioco == null || String.IsNullOrEmpty(testo)||autore==null)
                throw new ArgumentException("videogioco == null || String.IsNullOrEmpty(testo)||autore==null");
            #endregion         

            this._videogioco = videogioco;
            this._testo = testo;
            this._autore = autore;
            this._dataImmissione = DateTime.Now;
            this._videogioco.Recensione = this;
            this._commenti = new List<Commento>();
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
                OnRecensioneChanged();
            }
        }

        public Recensore Autore
        {
            get { return _autore; }
        }

        public IEnumerable<AspettoValore> GetAspettiValutati()
        {
            return _aspettiValutati.List;
        }

        public AspettiValutati AspettiValutati
        {
            get { return _aspettiValutati; }
        }

        public IEnumerable<Commento> Commenti
        {
            get { return _commenti; }
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

        public void ModificaAspetto(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
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
            if (RecensioneChanged != null)
            {
                RecensioneChanged(null, EventArgs.Empty);
            }
        }




    }
}
