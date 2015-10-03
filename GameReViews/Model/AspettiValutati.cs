using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    /* Classe contenitore per gli Aspetti Valutati, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * per l'aggiunta in questo caso non c'è bisogno di avere una precondizione in più, basta aggiornare il reference counting di Aspetti
     */
	public class AspettiValutati : AspettiValori<AspettoValutato>
	{
        public override void Add(AspettoValutato aspettoValutato)
        {
            #region Precondizioni
            if (aspettoValutato == null)
                throw new ArgumentNullException("aspettoValutato == null");
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new HashSet<AspettoValutato>();
            #endregion

            if (!this._aspettiValori.Add(aspettoValutato))
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!");
            // aggiorno reference counting
            Document.GetInstance().Aspetti.Add(aspettoValutato.Aspetto);

        }
    }
}
