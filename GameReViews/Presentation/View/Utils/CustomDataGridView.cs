using System.Windows.Forms;

namespace GameReViews
{
    public delegate void CellClickedDelegate(object selectedObject);

    public partial class CustomDataGridView : UserControl
    {
        public event CellClickedDelegate CellClicked;

        public CustomDataGridView()
        {
            InitializeComponent();

            _dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            _dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             
        }

        public void InitDataSource(BindingSource source, string[][] headers)
        {
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.ColumnCount = headers.Length;
            

            for (int i = 0; i < headers.Length; i++)
            {
                _dataGridView.Columns[i].Name = headers[i][0];
                _dataGridView.Columns[i].DataPropertyName = headers[i][1];
            }

            _dataGridView.DataSource = source;
        }

        public void UpdateDataSource(BindingSource source)
        {
            _dataGridView.DataSource = source;
        }
            
        private void _dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellClicked != null && e.RowIndex != -1) // è -1 se è una cella dell'header
            {
                CellClicked(_dataGridView.Rows[e.RowIndex].DataBoundItem);
            }
        }
    }
}
