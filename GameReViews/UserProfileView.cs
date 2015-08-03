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
    public partial class UserProfileView : UserControl
    {
        public UserProfileView()
        {
            InitializeComponent();

            string [] columns = new string[] {"Preferenza", "Peso"} ;
            _preferenzeList.addColumns(columns);

            string[][] rows = new string[10][];
            rows[0] = new string[] { "Grafica", "10" };
            rows[1] = new string[] { "Grafica", "10" };
            rows[2] = new string[] { "Grafica", "10" };
            rows[3] = new string[] { "Grafica", "10" };
            rows[4] = new string[] { "Grafica", "10" };
            rows[5] = new string[] { "Grafica", "10" };
            rows[6] = new string[] { "Grafica", "10" };
            rows[7] = new string[] { "Grafica", "10" };
            rows[8] = new string[] { "Grafica", "10" };
            rows[9] = new string[] { "Grafica", "10" };
            _preferenzeList.addRows(rows);
        }

        private void _userInfoContainer_root_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _aggiungiPreferenzaButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _aggiungiPreferenza_Click(object sender, EventArgs e)
        {

        }
    }
}
