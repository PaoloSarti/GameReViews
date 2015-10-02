using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    /* Classe contenitore per le Preferenze, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * mentre per l'aggiunta, c'è la precondizione che un utente non può inserire nuovi aspetti nel sistema
     */
    public class Preferenze : AspettiValori<Preferenza>
    {
        public override void Add(Aspetto aspetto, int value)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori<Preferenza>.IsValueValid(value))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new List<Preferenza>();

            // un utente non può inserire nuovi aspetti nel sistema
            if (!Document.GetInstance().Aspetti.Contains(aspetto))
                throw new ArgumentException("!Model.getInstance().Aspetti.Contains(aspetto)");
            #endregion

            try
            {
                this._aspettiValori.Add(new Preferenza(aspetto, value));
            }
            catch (ArgumentException) 
            { 
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!");
            }

            // aggiorno reference counting
            Document.GetInstance().Aspetti.Add(aspetto);
        }
    }
}
