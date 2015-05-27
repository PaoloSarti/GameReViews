using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Preferenze : AspettiValori
    {
        public override void Add(Aspetto aspetto, int value)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(value))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");

            // un utente non può inserire nuovi aspetti nel sistema
            if (!Model.getInstance().Aspetti.Contains(aspetto))
                throw new ArgumentException("!Model.getInstance().Aspetti.Contains(aspetto)");
            #endregion
            
            this._aspettiValori.Add(aspetto, value);

            // aggiorno reference counting
            Model.getInstance().Aspetti.Add(aspetto);
        }
    }
}
