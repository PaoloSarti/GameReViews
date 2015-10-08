using System.Windows.Forms;

namespace GameReViews.Presentation.View
{
    public partial class AggiungiRecensione : Form
    {

        public AggiungiRecensione()
        {
            InitializeComponent();

        }

        public string Testo
        {
            get
            {
                return _recensioneText.Text;
            }
        }

    }
}
