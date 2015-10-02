using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Recensore : UtenteRegistrato
    {

        public Recensore(string nome, string passowrd) : base(nome, passowrd)
        {
        }

        // Non manteniamo una lista (che dovrebbe essere consistente), ma lo calcoliamo dal modello
        public IEnumerable<Recensione> Recensioni
        {
            get
            {
                return Document.GetInstance().Videogiochi.Recensioni.Where(r => r.Autore.Equals(this));
            }
        }         
    }
}
