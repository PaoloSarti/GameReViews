using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameReViews.Model
{

    public class UtenteRegistrato
    {
        //i campi _nome e _password sono impostabili solo allla creazione del nuovo oggetto quindi readonly
        private readonly string _nome;
        private readonly string _password;
        
        //Poichè Preferenze è una classe contenitore, anch'essa è readonly
        private readonly Preferenze _preferenze;

        public event EventHandler UtenteChanged;

        public UtenteRegistrato(string nome, string password)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(password))
                throw new ArgumentException("String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(password)");
            #endregion

            this._nome = nome;
            this._password = password;

            _preferenze = new Preferenze();
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string Password
        {
            get { return _password; }
        } 

        public IEnumerable<KeyValuePair<Aspetto, int>> GetPreferenze()
        {
            return this._preferenze.AspettiValutati;
        }

        public Preferenze Preferenze
        {
            get { return _preferenze; }
        } 

        public virtual void AddPreferenza(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            this._preferenze.Add(aspetto, valutazione);

            OnChanged();
        }

        public virtual void RemovePreferenza(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            _preferenze.Remove(aspetto);

            OnChanged();
        }

        public virtual void ModificaPreferenza(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _preferenze.ModificaValutazione(aspetto, valutazione);

            OnChanged();
        }

        protected virtual void OnChanged()
        {
            if(UtenteChanged!=null)
            {
                UtenteChanged(null, EventArgs.Empty);
            }
        }

    }
}
