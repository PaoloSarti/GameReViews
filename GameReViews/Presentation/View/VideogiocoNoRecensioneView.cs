using System;
using System.Windows.Forms;

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
