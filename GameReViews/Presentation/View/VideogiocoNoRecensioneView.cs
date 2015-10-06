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

        public VideogiocoNoRecensioneView()
        {
            InitializeComponent();
        }

        public void abilitaAggiuntaRecensione(bool value)
        {
            _aggiungiRecensione.Visible = value;
        }

        private void _aggiungiRecensione_Click(object sender, EventArgs e)
        {
            if (AggiuntaRecensione != null)
                AggiuntaRecensione(null, EventArgs.Empty);
        }
    }
}
