using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Aspetto
    {
        private readonly string _nome;
        private readonly string _descrizione;

        public Aspetto(string nome, string descrizione = "")
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(nome) || descrizione == null)
                throw new ArgumentException("String.IsNullOrEmpty(nome) || descrizione == null");
            #endregion

            this._nome = nome;
            this._descrizione = descrizione;
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
        }
    }
}
