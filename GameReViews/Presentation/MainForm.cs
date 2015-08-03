using GameReViews.Model;
using GameReViews.Presentation.Presenter;
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

        private VideogiochiListView _recensioniView;
        private VideogiochiListView _videogiochiView;
        private UserProfileView _userProfileView;

        private LogSignInView _logSignInView;

        public MainForm()
        {
            InitializeComponent();

            _recensioniView = new VideogiochiListView();
            _videogiochiView = new VideogiochiListView();
            _userProfileView = new UserProfileView();

            _logSignInView = new LogSignInView();

            _recensioniView.GetCustomDataGrid().CellClicked += onVideogiocoSelected;
            _videogiochiView.GetCustomDataGrid().CellClicked += onVideogiocoSelected;

            _recensioniView.Dock = DockStyle.Fill;
            _userProfileView.Dock = DockStyle.Fill;
            _videogiochiView.Dock = DockStyle.Fill;
            _logSignInView.Dock = DockStyle.Fill;

            // hack per partire dalla schermata delle recensioni
            _recensioniButton_Click(null, null);

            new VideogiochiPresenter(_videogiochiView);
            new VideogiochiRecensitiPresenter(_recensioniView);
            new UtentePresenter(_userProfileView);
            ToolbarPresenter toolbarPresenter = new ToolbarPresenter(_utenteButton);
            
            toolbarPresenter.LoginUtente += this._utente_Login;
            toolbarPresenter.ProfiloUtente += this._utente_Profilo;

        }

        // scatta quando si seleziona un item dalla lista. Fa vedere la vista dettagliata del videogioco e della relativa recensione (se presente)
        private void onVideogiocoSelected(Videogioco videogioco)
        {
            //String nomeGiocoSelezionato = nomeVidegioco; //_rowsVideogiochi[((DataGridViewCellEventArgs)e).RowIndex][0];

            Videogioco videogiocoSelezionato = videogioco;

            VideogiocoRootView root = new VideogiocoRootView(videogiocoSelezionato);

            root.Dock = DockStyle.Fill;
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

        // serve una classe AspettoValore con due campi: Aspetto e string/int valore
        private void _utente_Login(object sender, EventArgs e)
        {

            if (_currentControl != _logSignInView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_logSignInView);

                _currentControl = _logSignInView;
            }
        }


        private void _utente_Profilo(object sender, EventArgs e)
        {

            if (_currentControl != _userProfileView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_userProfileView);

                _currentControl = _userProfileView;
            }
        }
    }
}
