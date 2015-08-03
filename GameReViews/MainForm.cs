using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews
{
    public partial class _root : Form
    {

        private Control _currentControl;

        private CustomListView _recensioniListView;
        private UserProfileView _userProfile;

        public _root()
        {
            InitializeComponent();

            _recensioniListView = new CustomListView();
            _userProfile = new UserProfileView();

            fetchData();

            _recensioniListView.Dock = DockStyle.Fill;
            _userProfile.Dock = DockStyle.Fill;

            _viewsContainer.Controls.Add(_recensioniListView);
            _currentControl = _recensioniListView;
        }

        private void fetchData()
        {
            string[] columns = new string[] { "Nome Gioco", "Nome Recensore", "Valutazione" };
            _recensioniListView.addColumns(columns);

            string[][] rows = new string[10][];
            rows[0] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[1] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[2] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[3] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[4] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[5] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[6] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[7] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[8] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            rows[9] = new string[] { "Nome Gioco", "Nome recensore", "Valutazione" };
            _recensioniListView.addRows(rows);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _recensioniButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _recensioniListView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_recensioniListView);

                _currentControl = _recensioniListView;
            }
        }

        private void _videogiochiButton_Click(object sender, EventArgs e)
        {
            
        }

        private void _utenteButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _userProfile)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_userProfile);

                _currentControl = _userProfile;
            }
        }

        private void _viewsContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
