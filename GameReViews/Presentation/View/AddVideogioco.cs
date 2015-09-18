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
            _videogiocoImage.Image = GameReViews.Properties.Resources.nonsensCapture;
            _genereComboBox.DataSource = Enum.GetValues(typeof(Genere));
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void _videogiocoImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _videogiocoImage.Image = Image.FromFile(openFileDialog.FileName);
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
    }
}
