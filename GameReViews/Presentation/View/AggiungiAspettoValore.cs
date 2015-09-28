using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameReViews.Presentation.View
{
    public partial class AggiungiAspettoValore : Form
    {
        private IEnumerable<Aspetto> _aspetti;

        public AggiungiAspettoValore(IEnumerable<Aspetto> aspetti)
        {
            InitializeComponent();
            this._aspetti = aspetti;

            List<string> nomi = (from aspetto in _aspetti select aspetto.Nome).ToList();

            _aspettiCombo.DataSource = nomi;

        }

        public Aspetto AspettoSelezionato
        {
            get
            {
                return GetAspettoByNome((string)_aspettiCombo.SelectedItem);
            }
        }

        public int Valutazione
        {
            get
            {
                return (int) _valutazione.Value;
            }
        }

        private void _aspettiCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string nome = (string) _aspettiCombo.SelectedItem;

            try
            {
                _descrizioneTextBox.Text = this.GetAspettoByNome(nome).Descrizione;
            }
            catch(ArgumentException)
            {
                _descrizioneTextBox.Text = "Inserisci descrizione";
            }
        }

        private Aspetto GetAspettoByNome(String nome)
        {
            foreach(Aspetto a in _aspetti)
            {
                if (a.Nome == nome)
                    return a;
            }
            throw new ArgumentException();
        }

        public string Nome
        {
            get
            {
                return _aspettiCombo.Text;
            }
        }


        public string Descrizione
        {
            get
            {
                return _descrizioneTextBox.Text;
            }
        }


        public string Titolo
        {
            get
            {
                return _titoloLabel.Text;
            }
            set
            { 
                _titoloLabel.Text = value;
            }
        }

        public void EnableEdit(bool enable)
        {
            _descrizioneTextBox.ReadOnly = !enable;
        }

    }
}
