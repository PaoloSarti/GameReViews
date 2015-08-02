using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews
{
    public partial class CustomDataGridView : UserControl
    {
        public delegate void CellClickedDelegate(Videogioco videogiocoSelezionato);

        public event CellClickedDelegate CellClicked;

        public CustomDataGridView()
        {
            InitializeComponent();

            _dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            _dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
             
        }

        public void setDataSource(BindingSource source, string[][] headers)
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

            
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellClicked != null && e.RowIndex != -1) // è -1 se è una cella dell'header
            {
                Videogioco videogiocoSelezionato = (Videogioco) _dataGridView.Rows[e.RowIndex].DataBoundItem;
                CellClicked(videogiocoSelezionato);
            }


            // reminder
            //if ( ((string) _dataGridView.Rows[e.RowIndex].Tag) == "lul" )
            //    Environment.Exit(1);
        }
    }
}
