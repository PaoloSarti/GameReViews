using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameReViews.Model
{
    public class Videogioco
    {
        private string _nome;
        private DateTime _dataRilascio;
        private Image _image;

        private static Image _defaultImage = GameReViews.Properties.Resources.ic_insert_photo_white_48dp;

        private Recensione _recensione;
        private Genere _genere;

        public event EventHandler Changed;

        public Videogioco(string nome, DateTime dataRilascio, Genere genere)
        {
            // l'enumerativo garantisce già che non si utilizzino valori non ammessi
            // DateTime è una struct, non può avere come valore null
            if (String.IsNullOrEmpty(nome)) 
                throw new ArgumentNullException("String.IsNullOrEmpty(nome)");

            this._nome = nome;
            this._dataRilascio = dataRilascio;
            this._genere = genere;

            this._recensione = null;

            this._image = _defaultImage;
        }

        public Videogioco(string nome, DateTime dataRilascio, Genere genere, Image image) 
            : this(nome, dataRilascio, genere)
        {
            if (image == null)
                throw new ArgumentNullException("image == null");

            this._image = image;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("String.IsNullOrEmpty(value)");

                _nome = value;
                OnChange();
            }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set
            {
                _dataRilascio = value;
                OnChange();
            }
        }

        public Genere Genere
        {
            get { return _genere; }
            set
            {
                // l'enumerativo garantisce già che non si utilizzino valori non ammessi
                _genere = value;
                OnChange();
            }
        }

        public Recensione Recensione
        {
            get { return _recensione; }
            set 
            {
                // dobbiamo aggiornare il reference counting degli aspetti
                if(_recensione!=null)
                    _recensione.RemoveAllAspettiValutati();

                _recensione = value; 

                OnChange(); 
            }
        }

        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnChange();
            }
        }

        // per avere l'unicità nei Set, ridefinisco Equals e GetHashCode
        public override bool Equals(System.Object obj)
        {
            // Se il paramentro è nullo ritorno falso
            if (obj == null)
            {
                return false;
            }

            // Se il paramentro non può essere castato ad Aspetto ritorno false.
            Videogioco a = obj as Videogioco;
            if ((System.Object)a == null)
            {
                return false;
            }

            // Ritorno true se il nome e la data sono gli stessi
            return (_nome == a._nome && _dataRilascio == a._dataRilascio);
        }

        public override int GetHashCode()
        {
            return _nome.GetHashCode() + _dataRilascio.GetHashCode();
        }

        private void OnChange()
        {
            if(Changed!=null)
                Changed(null, EventArgs.Empty);
        }
    }
}
