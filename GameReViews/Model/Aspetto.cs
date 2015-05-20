using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    public class Aspetto
    {
        private readonly string _nome;
        private readonly string _descrizione;

        public Aspetto(string nome, string descrizione)
        {
            // la descrizione si può anche non mettere, ma non può essere null
            if (String.IsNullOrEmpty(nome) || descrizione == null)
                return; // throws ...

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
