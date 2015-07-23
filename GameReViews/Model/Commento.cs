using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    class Commento
    {
        private String _testo;
        private readonly List<Commento> _risposte;
        private UtenteRegistrato _autore;

        public Commento(String testo, UtenteRegistrato autore)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(testo) || autore == null)
                throw new ArgumentException("String.IsNullOrEmpty(testo)||autore==null");
            #endregion         

            this._autore = autore;
            this._testo = testo;
            this._risposte = new List<Commento>();
        }


        public IEnumerable<Commento> Risposte
        {
            get { return _risposte; }
        } 

        public String Testo
        {
            get { return _testo; }
            set { _testo = value; }
        }

        public void Rispondi(String testo, UtenteRegistrato autore)
        {
            Commento child = new Commento(testo, autore);

            _risposte.Add(child);
        }



    }
}
