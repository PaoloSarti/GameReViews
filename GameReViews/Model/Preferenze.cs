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
            //non dovrebbe esserci il controllo aspetto giaà contenuto?
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new Dictionary<Aspetto, int>();

            // un utente non può inserire nuovi aspetti nel sistema
            if (!Model.getInstance().Aspetti.Contains(aspetto))
                throw new ArgumentException("!Model.getInstance().Aspetti.Contains(aspetto)");
            #endregion

            try
            {
                this._aspettiValori.Add(aspetto, value);
            }
            catch (ArgumentNullException e) { throw new ArgumentNullException("aspetto == null"); }
            catch (ArgumentException e) { throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!"); }

            // aggiorno reference counting
            Model.getInstance().Aspetti.Add(aspetto);
        }
    }
}
