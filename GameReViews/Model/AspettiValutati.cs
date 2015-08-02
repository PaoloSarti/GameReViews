using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    /* Classe contenitore per gli Aspetti Valutati, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * per l'aggiunta in questo caso non c'è bisogno di avere una precondizione in più, basta aggiornare il reference counting di Aspetti
     */
	public class AspettiValutati : AspettiValori
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
            #endregion

            try
            {
                this._aspettiValori.Add(aspetto, value);
            }
            catch (ArgumentException) 
            {
                // TODO mah
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!"); 
            }

            // aggiorno reference counting
            Document.GetInstance().Aspetti.Add(aspetto);
        }
    }
}
