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
