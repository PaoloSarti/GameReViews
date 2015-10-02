using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.View
{
    public partial class VideogiocoNoRecensioneView : UserControl
    {
        public event EventHandler AggiuntaRecensione;

        public Sessione _sessione;

        public VideogiocoNoRecensioneView(Sessione sessione)
        {
            InitializeComponent();

            _sessione = sessione;

            if (!(_sessione.UtenteCorrente is Recensore))
            {
                _aggiungiRecensione.Visible = false;
            }
            else
            {
                _aggiungiRecensione.Visible = true;
            }
        }

        private void _aggiungiRecensione_Click(object sender, EventArgs e)
        {
            if (AggiuntaRecensione != null)
                AggiuntaRecensione(null, EventArgs.Empty);
        }

    }
}
