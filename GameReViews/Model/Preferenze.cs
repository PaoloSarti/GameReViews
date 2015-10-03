using System;
using System.Collections.Generic;

namespace GameReViews.Model
{
    /* Classe contenitore per le Preferenze, eredita la modalità di interazione con Aspetti per quanto riguarda la rimozione/modifica,
     * mentre per l'aggiunta, c'è la precondizione che un utente non può inserire nuovi aspetti nel sistema
     */
    public class Preferenze : AspettiValori<Preferenza>
    {
        public override void Add(Preferenza preferenza)
        {
            #region Precondizioni
            if (preferenza.Aspetto == null)
                throw new ArgumentNullException("aspetto == null");
            if (!AspettiValori<Preferenza>.IsValueValid(preferenza.Valore))
                throw new ArgumentException("!AspettiValori.IsValueValid(value)");
            if (this._aspettiValori == _emptyAspettiValori)
                this._aspettiValori = new HashSet<Preferenza>();

            // un utente non può inserire nuovi aspetti nel sistema
            if (!Document.GetInstance().Aspetti.Contains(preferenza.Aspetto))
                throw new ArgumentException("!Model.getInstance().Aspetti.Contains(aspetto)");
            #endregion

            if(!this._aspettiValori.Add(preferenza))
                throw new ArgumentException("this._aspettiValori.Add(aspetto, value) aspetto deve essere unico!");

            // aggiorno reference counting
            Document.GetInstance().Aspetti.Add(preferenza.Aspetto);
        }
    }
}
