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

            /*
            var list = Document.GetInstance().Videogiochi.List.ToList();

             _dataGridView.ColumnCount = 3;
             _dataGridView.AutoGenerateColumns = false;

            _dataGridView.Columns[0].Name = "Nome Gioco";
            _dataGridView.Columns[0].DataPropertyName = "nome";
            _dataGridView.Columns[1].Name = "Data Rilascio";
            _dataGridView.Columns[1].DataPropertyName = "dataRilascio";
            _dataGridView.Columns[2].Name = "Genere";
            _dataGridView.Columns[2].DataPropertyName = "genere";

            BindingList<Videogioco> bindingList = new BindingList<Videogioco>(list);
            BindingSource source = new BindingSource(bindingList, null);
            _dataGridView.DataSource = source;
             * */
             
        }

        public void setDataSource(View.VideogiochiFilter source, string[][] headers)
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

        /*
        public void addColumns(string[] columns)
        {
            _dataGridView.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                _dataGridView.Columns[i].Name = columns[i];
            }
        }
        */

        /*
        public void addRows(string[][] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                _dataGridView.Rows.Add(rows[i]);

                // reminder
                //_dataGridView.Rows[i].Tag = "lul";
            }
        }
        */

            
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
