using System;

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


        //per avere l'unicità nei Set, ridefinisco Equals e GetHashCode
        public override bool Equals(System.Object obj)
        {
            // Se il paramentro è nullo ritorno falso
            if (obj == null)
            {
                return false;
            }

            // Se il paramentro non può essere castato ad Aspetto ritorno false.
            Aspetto a = obj as Aspetto;
            if ((System.Object)a == null)
            {
                return false;
            }

            // Ritorno true se il nome è lo stesso
            return (_nome == a._nome);
        }

        public override int GetHashCode()
        {
            return _nome.GetHashCode();
        }

        public override string ToString()
        {
            return _nome;
        }

    }
}
