using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    class Recensione
    {
        private readonly Videogioco _videogioco;
        private readonly DateTime _dataImmissione;
        private string _testo;

        // questi due campi sono stati sostiuti da _aspettiValutatoManager
        // in questo modo possiamo evitare di ripetere lo stesso esatto codice dei metodi
        // GetAspettiValutati, AddAspettoValutato,  RemoveAspettoValutato, ModificaAspetto
        // all'interno di utente registrato.

        // volendo recensione e utente potrebbero estendere una bellissima classe astratta "aspettiValutatiUser"
        // che fornisca l'implmentazione base di questi metodi ?? lol
        // secondo me bisogna risolvere l'ambiguità tra AspettiValutati e Preferenze, in un qualche modo.

        //private Dictionary<Aspetto, int> _aspettiValutati;
        //private readonly Dictionary<Aspetto, int> _emptyAspettiValutati = new Dictionary<Aspetto, int>();

        private AspettiValutatiManager _aspettiValutatoManager;

        public Recensione(Videogioco videogioco, string testo)
        {
            if (videogioco == null || String.IsNullOrEmpty(testo))
                return; // throws ...

            this._videogioco = videogioco;
            this._testo = testo;

            this._dataImmissione = DateTime.Now;

            //this._aspettiValutati = _emptyAspettiValutati;
            _aspettiValutatoManager = new AspettiValutatiManager();
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
                if (String.IsNullOrEmpty(_testo))
                    return;

                _testo = value; 
            }
        }

        public IEnumerable<AspettoValutato> GetAspettiValutati()
        {
            return this._aspettiValutatoManager.AspettiValutati;
        }

        public void AddAspettoValutato(AspettoValutato aspettoValutato)
        {
            this._aspettiValutatoManager.AddAspettoValutato(aspettoValutato);
        }

        public void RemoveAspettoValutato(Aspetto aspetto)
        {
            _aspettiValutatoManager.RemoveAspettoValutato(aspetto);
        }

        public void ModificaAspetto(Aspetto aspetto, int valutazione)
        {
            _aspettiValutatoManager.ModificaValutazioneAspetto(aspetto, valutazione);
        }
    }
}
