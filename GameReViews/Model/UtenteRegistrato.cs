using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameReViews.Model
{
    public class UtenteRegistrato
    {
        private string _nome;
        private string _password;
        private Preferenze _preferenze;

        public UtenteRegistrato(string nome, string passowrd)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(passowrd))
                throw new ArgumentException("String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(passowrd)");
            #endregion

            this._nome = nome;
            this._password = passowrd;

            _preferenze = new Preferenze();
        }

        // TODO: add methods

        public IEnumerable<KeyValuePair<Aspetto, int>> GetPreferenze()
        {
            return this._preferenze.AspettiValutati;
        }

        public void AddPreferenza(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            this._preferenze.Add(aspetto, valutazione);
        }

        public void RemovePreferenza(Aspetto aspetto)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            #endregion

            _preferenze.Remove(aspetto);
        }

        public void ModificaPreferenza(Aspetto aspetto, int valutazione)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(valutazione))
                throw new ArgumentException("!AspettiValori.IsValueValid(valutazione)");
            #endregion

            _preferenze.ModificaValutazione(aspetto, valutazione);
        }
    }
}
