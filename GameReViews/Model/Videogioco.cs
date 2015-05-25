using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni
    public class Videogioco
    {
        private string _nome;
        private DateTime _dataRilascio;
        private Image _image;
        private Recensione _recensione;  //riferimento
        private Genere _genere;

        public Videogioco(string nome, DateTime dataRilascio, Genere genere)
        {
            if (String.IsNullOrEmpty(nome) || dataRilascio == null || genere == null)
                return; // throws ...

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
                return; // throws ...

            this._image = image;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                    return;

                _nome = value; 
            }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set
            {
                if (_dataRilascio == null)
                    return;

                _dataRilascio = value; 
            }
        }

        public Genere Genere
        {
            get { return _genere; }
            set
            {
                if (_genere == null)
                    return;

                _genere = value;
            }
        }

        public Recensione Recensione
        {
            get { return _recensione; }
            set { _recensione = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Videogioco))
                return false;
            //Uaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            Videogioco other = (Videogioco)obj;
            if (other.Nome.Equals(this.Nome)&&other.DataRilascio.Equals(this.DataRilascio))
                return true;
            return false;
        }

    }
}
