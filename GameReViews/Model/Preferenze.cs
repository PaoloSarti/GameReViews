using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    /* Classe contenitore per le Preferenze, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * mentre per l'aggiunta, c'è la precondizione che un utente non può inserire nuovi aspetti nel sistema
     */
    public class Preferenze : AspettiValori
    {
        public override void Add(Aspetto aspetto, int value)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(value))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new Dictionary<Aspetto, int>();

            // un utente non può inserire nuovi aspetti nel sistema
            if (!Model.GetInstance().Aspetti.Contains(aspetto))
                throw new ArgumentException("!Model.getInstance().Aspetti.Contains(aspetto)");
            #endregion

            try
            {
                this._aspettiValori.Add(aspetto, value);
            }
            catch (ArgumentException) 
            { 
                // TODO maH
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!");
            }

            // aggiorno reference counting
            Model.GetInstance().Aspetti.Add(aspetto);
        }
    }
}
