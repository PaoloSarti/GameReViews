using GameReViews.Model;
using GameReViews.View;
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
        private VideogiochiListView _videogiochiView;
        private UserProfileView _userProfileView;

        private LogSignInView _logSignInView;

        public MainForm()
        {
            InitializeComponent();

            _recensioniView = new CustomDataGridView();
            _videogiochiView = new VideogiochiListView();
            _userProfileView = new UserProfileView();

            _logSignInView = new LogSignInView();

            _recensioniView.CellClicked += onVideogiocoSelected;
            _videogiochiView.getCustomDataGrid().CellClicked += onVideogiocoSelected;

            bindData();

            _recensioniView.Dock = DockStyle.Fill;
            _userProfileView.Dock = DockStyle.Fill;
            _videogiochiView.Dock = DockStyle.Fill;
            _logSignInView.Dock = DockStyle.Fill;

            // hack per partire dalla schermata delle recensioni
            _recensioniButton_Click(null, null);
        }

        private void bindData()
        {
            string[][] headers = new string[3][];
            headers[0] = new string[2] { "Nome Gioco", "nome" };
            headers[1] = new string[2] { "Data Rilascio", "dataRilascio" };
            headers[2] = new string[2] { "Genere", "genere" };

            IList<Videogioco> videogiochi = Document.GetInstance().Videogiochi.List.ToList();
            BindingList<Videogioco> bindingList = new BindingList<Videogioco>(videogiochi);

            // hanno la stessa sorgente dati, però nel caso delle recensioni è filtrata, per non far vedere i videogiochi senza recensione
            VideogiochiFilter source_recensioni = new VideogiochiFilter(bindingList);
            source_recensioni.Filter = "true";

            VideogiochiFilter source_videogiochi = new VideogiochiFilter(bindingList);

            _recensioniView.setDataSource(source_recensioni, headers);
            _videogiochiView.getCustomDataGrid().setDataSource(source_videogiochi, headers);
        }

        // scatta quando si seleziona un item dalla lista. Fa vedere la vista dettagliata del videogioco e della relativa recensione (se presente)
        private void onVideogiocoSelected(Videogioco videogioco)
        {
            //String nomeGiocoSelezionato = nomeVidegioco; //_rowsVideogiochi[((DataGridViewCellEventArgs)e).RowIndex][0];

            Videogioco videogiocoSelezionato = videogioco;
            Recensione recensione = videogiocoSelezionato.Recensione;

            VideogiocoRootView root = new VideogiocoRootView(videogiocoSelezionato, recensione);

            _viewsContainer.Controls.Remove(_currentControl);
            _viewsContainer.Controls.Add(root);

            _currentControl = root;
        }

        private void _recensioniButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _recensioniView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_recensioniView);

                _currentControl = _recensioniView;
            }
        }

        private void _videogiochiButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _videogiochiView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_videogiochiView);

                _currentControl = _videogiochiView;
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

                //fetchData(columns, rows, _userProfileView.getCustomDataGrid());
            }
        }
    }
}
