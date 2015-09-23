using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.Presentation.View
{
    public partial class AddVideogioco : Form
    {
        private string _nome;
        private DateTime _dataRilascio;
        private Image _image;
        private Genere _genere;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set { _dataRilascio = value; }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public Genere Genere
        {
            get { return _genere; }
            set { _genere = value; }
        }

        public AddVideogioco()
        {
            InitializeComponent();
            _videogiocoImage.Image = GameReViews.Properties.Resources.ic_insert_photo_white_48dp;
            _genereComboBox.DataSource = Enum.GetValues(typeof(Genere));
        }

        private void _videogiocoImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _videogiocoImage.Image = Image.FromFile(openFileDialog.FileName);
                    _videogiocoImage.Padding = new Padding(0);
                }
            }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            _nome = _nomeView.Text;
            _dataRilascio = _dataRilascioPicker.Value;
            _image = _videogiocoImage.Image;
            _genere = (Genere) _genereComboBox.SelectedItem;
        }

        private void _videogiocoImage_MouseHover(object sender, EventArgs e)
        {
            _videogiocoImage.BackColor = Color.FromArgb(25, 118, 210);
        }

        private void _videogiocoImage_MouseLeave(object sender, EventArgs e)
        {
            _videogiocoImage.BackColor = Color.FromArgb(33, 150, 243);
        }
    }
}
