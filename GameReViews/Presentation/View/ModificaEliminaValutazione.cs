using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.View
{

    public partial class ModificaEliminaValutazione : Form
    {
        private bool _elimina;

        public ModificaEliminaValutazione(AspettoValore a)
        {
            InitializeComponent();

            _elimina = false;

            _nomeText.Text = a.Aspetto.Nome;

            _descrizioneText.Text = a.Aspetto.Descrizione;

            _valutazioneNumeric.Value = a.Valore;

        }

        public bool Elimina
        {
            get { return _elimina; }
        }

        public int Valore
        {
            get { return (int) _valutazioneNumeric.Value; }
        }

        public string Titolo
        {
            get { return _titoloLabel.Text; }
            set { _titoloLabel.Text = value; }
        }


        private void _eliminaButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare la valutazione?", "Elimina Preferenza", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _elimina = true;
                //chiudo con ok, ma segnalo che si vuole eliminare la preferenza
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
