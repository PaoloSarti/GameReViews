using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews
{
    public partial class CustomListView : UserControl
    {

        public CustomListView()
        {
            InitializeComponent();

            //Control[] controls = listView.Controls.Find("_dataGridView", true);
            //DataGridView dgw = (DataGridView)controls[0];

            _dataGridView.ColumnCount = 3;
            _dataGridView.Name = "dataGridViewName";
            _dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            _dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            //_dataGridView.Columns[0].Name = "Nome Gioco";
            //_dataGridView.Columns[1].Name = "Nome Recensore";
            //_dataGridView.Columns[2].Name = "Valutazione";

            _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string[] row01 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row11 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row21 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row31 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row41 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row51 = { "Nome Gioco", "Nome recensore", "Valutazione" };
            //string[] row61 = { "Nome Gioco", "Nome recensore", "Valutazione" };

            //_dataGridView.Rows.Add(row01);
            //_dataGridView.Rows.Add(row11);
            //_dataGridView.Rows.Add(row21);
            //_dataGridView.Rows.Add(row31);
            //_dataGridView.Rows.Add(row41);
            //_dataGridView.Rows.Add(row51);
            //_dataGridView.Rows.Add(row61);

            _dataGridView.Columns[0].DisplayIndex = 0;
            _dataGridView.Dock = DockStyle.Fill;
        }

        public void addColumns(string[] columns)
        {
            _dataGridView.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                _dataGridView.Columns[i].Name = columns[i];
            }
        }

        public void addRows(string[][] rows)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                _dataGridView.Rows.Add(rows[i]);
            }
        }
    }
}
