using System;
namespace GameReViews.Model
{
    public abstract class AspettoValore
    {
        // vedi requisiti non funzionali del progetto
        private readonly static int _valoreMinimo = 0;
        private readonly static int _valoreMassimo = 10;

        private readonly Aspetto _aspetto;
        private int _valore;

        public AspettoValore(Aspetto aspetto, int valore)
        {
            #region Precondizioni
            if (aspetto == null)
                throw new ArgumentNullException("aspetto==null");
            if (!IsValoreValid(valore))
                throw new ArgumentException("!IsValoreValid(valore)");
            #endregion


            _aspetto = aspetto;
            _valore = valore;
        }

        public Aspetto Aspetto
        {
            get { return _aspetto; }
        }

        public int Valore
        {
            get { return _valore; }
            set 
            {
                if (!IsValoreValid(value))
                    throw new ArgumentException("!IsValoreValid(value)");
                _valore = value;
            }
        }

        protected bool IsValoreValid(int valore)
        {
            return valore <= ValoreMassimo && valore >= ValoreMinimo;
        }

        public static int ValoreMassimo
        {
            get { return AspettoValore._valoreMassimo; }
        }

        public static int ValoreMinimo
        {
            get { return AspettoValore._valoreMinimo; }
        }


        //per avere l'unicità nei Set, ridefinisco Equals e GetHashCode
        public override bool Equals(System.Object obj)
        {
            // Se il paramentro è nullo ritorno falso
            if (obj == null)
            {
                return false;
            }

            // Se il paramentro non può essere castato ad AspettoValore ritorno false.
            AspettoValore a = obj as AspettoValore;
            if ((System.Object)a == null)
            {
                return false;
            }

            // Ritorno true se l'aspetto è lo stesso
            return (this._aspetto.Equals(a._aspetto));
        }

        public override int GetHashCode()
        {
            return this._aspetto.GetHashCode();
        }
    }

    public class Preferenza : AspettoValore
    {
        public Preferenza(Aspetto aspetto, int valore)
            : base(aspetto, valore)
        {
        }
    }

    public class AspettoValutato : AspettoValore
    {
        public AspettoValutato(Aspetto aspetto, int valore)
            : base(aspetto, valore)
        {
        }
    }

}
