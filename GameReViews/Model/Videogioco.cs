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
        private Recensione _recensione;  //riferimento
        private Genere _genere;

        public Videogioco(string nome, DateTime dataRilascio, Genere genere)
        {
            //l'enumerativo garantisce già che non si utilizzino valori non ammessi
            //DateTime è una struct, non può avere come valore null
            if (String.IsNullOrEmpty(nome)) 
                throw new ArgumentNullException("String.IsNullOrEmpty(nome)");

            this._nome = nome;
            this._dataRilascio = dataRilascio;
            this._genere = genere;

            this._recensione = null;

            // TODO
            this._image = Image.FromFile("default_image_videogioco");
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
            }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set
            {
                _dataRilascio = value; 
            }
        }

        public Genere Genere
        {
            get { return _genere; }
            set
            {
                //l'enumerativo garantisce già che non si utilizzino valori non ammessi
                _genere = value;
            }
        }

        public Recensione Recensione
        {
            get { return _recensione; }
            set { _recensione = value; }
        }
    }
}
