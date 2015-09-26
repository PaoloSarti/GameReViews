using GameReViews.Model;
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

            _aspettiCombo.DataSource = _aspetti.ToList();
        }

        public Aspetto AspettoSelezionato
        {
            get
            {
                return (Aspetto) _aspettiCombo.SelectedItem;
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
            Aspetto aspetto = (Aspetto) _aspettiCombo.SelectedItem;
            _descrizioneTextBox.Text = aspetto.Descrizione;
        }
    }
}
