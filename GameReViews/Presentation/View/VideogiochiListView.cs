using System.Windows.Forms;

namespace GameReViews
{
    public partial class VideogiochiListView : UserControl
    {
        public VideogiochiListView()
        {
            InitializeComponent();
        }

        public CustomDataGridView GetCustomDataGrid()
        {
            return _dataGridView;
        }

        public Button GetAggiungiVideogiocoButton()
        {
            return _aggiungiVideogiocoButton;
        }
    }
}
