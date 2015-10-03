namespace GameReViews.Model
{
    public abstract class AspettoValore
    {
        private readonly Aspetto _aspetto;
        private int _valore;

        public AspettoValore(Aspetto aspetto, int valore)
        {
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
            set { _valore = value; }
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
