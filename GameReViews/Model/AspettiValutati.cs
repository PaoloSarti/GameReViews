using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
	class AspettiValutati : AspettiValori
	{
        public override void Add(Aspetto aspetto, int value)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori.IsValueValid(value))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            #endregion

            this._aspettiValori.Add(aspetto, value);

            // aggiorno reference counting
            Model.getInstance().Aspetti.Add(aspetto);
        }
    }
}
