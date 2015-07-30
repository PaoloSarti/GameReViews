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
    public partial class MainForm : Form
    {

        private Control _currentControl;

        private CustomDataGridView _recensioniView;
        private VideogiochiView _videogiochiView;
        private UserProfileView _userProfileView;

        public MainForm()
        {
            InitializeComponent();

            _recensioniView = new CustomDataGridView();
            _videogiochiView = new VideogiochiView();
            _userProfileView = new UserProfileView();

            _recensioniView.Dock = DockStyle.Fill;
            _userProfileView.Dock = DockStyle.Fill;
            _videogiochiView.Dock = DockStyle.Fill;

            // da toligere quando avremo i dati
            _recensioniButton_Click(null, null);
        }

        private void fetchData(string[] columns, string[][] rows, CustomDataGridView view)
        {
            view.addColumns(columns);
            view.addRows(rows);
        }

        private void _recensioniButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _recensioniView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_recensioniView);

                _currentControl = _recensioniView;

                string[] columns = new string[] { "Nome Gioco", "Nome Recensore", "Valutazione" };
                _recensioniView.addColumns(columns);

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

                fetchData(columns, rows, _recensioniView);
            }
        }

        private void _videogiochiButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _videogiochiView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_videogiochiView);

                _currentControl = _videogiochiView;

                string[] columns = new string[] { "Nome", "Recensito" };

                string[][] rows = new string[10][];
                rows[0] = new string[] { "Nome", "SI/NO" };
                rows[1] = new string[] { "Nome", "SI/NO" };
                rows[2] = new string[] { "Nome", "SI/NO" };
                rows[3] = new string[] { "Nome", "SI/NO" };
                rows[4] = new string[] { "Nome", "SI/NO" };
                rows[5] = new string[] { "Nome", "SI/NO" };
                rows[6] = new string[] { "Nome", "SI/NO" };
                rows[7] = new string[] { "Nome", "SI/NO" };
                rows[8] = new string[] { "Nome", "SI/NO" };
                rows[9] = new string[] { "Nome", "SI/NO" };

                fetchData(columns, rows, _videogiochiView.getCustomDataGrid());
            }
        }

        private void _utenteButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _userProfileView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_userProfileView);

                _currentControl = _userProfileView;

                string[] columns = new string[] { "Preferenza", "Peso" };

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

                fetchData(columns, rows, _userProfileView.getCustomDataGrid());
            }
        }
    }
}
