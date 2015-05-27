using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public class Model
    {
        private static Model _instance;

        private readonly Aspetti _aspetti;
        private readonly UtentiRegistrati _utenti;
        private readonly Recensioni _recensioni;
        private readonly Videogiochi _videogiochi;

        public static Model getInstance()
        {
            if (_instance == null) 
            {
                _instance = new Model();
                return _instance;
            }
            else
                return _instance;
        }

        private Model()
        {
            _aspetti = new Aspetti();
            _utenti = new UtentiRegistrati();
            _recensioni = new Recensioni();
            _videogiochi = new Videogiochi();
        }

        public Aspetti Aspetti
        {
            get { return _aspetti; }
        }

        public UtentiRegistrati Utenti
        {
            get { return _utenti; }
        }

        public Recensioni Recensioni
        {
            get { return _recensioni; }
        }

        public Videogiochi Videogiochi
        {
            get { return _videogiochi; }
        }
    }
}
