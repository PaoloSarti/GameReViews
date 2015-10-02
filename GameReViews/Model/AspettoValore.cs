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
    }
}
