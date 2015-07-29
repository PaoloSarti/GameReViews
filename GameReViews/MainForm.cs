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

        private CustomListView _customListView;
        private UserProfileView _userProfile;

        public _root()
        {
            InitializeComponent();

            _customListView = new CustomListView();
            _userProfile = new UserProfileView();

            _customListView.Dock = DockStyle.Fill;
            _userProfile.Dock = DockStyle.Fill;

            _viewsContainer.Controls.Add(_customListView);
            _currentControl = _customListView;
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
            if (_currentControl != _customListView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_customListView);

                _currentControl = _customListView;
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
    }
}
