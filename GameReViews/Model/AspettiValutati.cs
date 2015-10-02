using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    /* Classe contenitore per gli Aspetti Valutati, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * per l'aggiunta in questo caso non c'è bisogno di avere una precondizione in più, basta aggiornare il reference counting di Aspetti
     */
	public class AspettiValutati : AspettiValori<AspettoValutato>
	{
        public override void Add(Aspetto aspetto, int value)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori<AspettoValutato>.IsValueValid(value))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new List<AspettoValutato>();
            #endregion

            try
            {
                this._aspettiValori.Add(new AspettoValutato(aspetto, value));
                // aggiorno reference counting
                Document.GetInstance().Aspetti.Add(aspetto);
            }
            catch (ArgumentException) 
            {
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!"); 
            }
        }
    }
}
