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

        private VideogiocoPresenter _videogiocoPresenter;

        private Sessione _sessione;

        public MainForm()
        {
            InitializeComponent();

            _sessione = new Sessione();

            _recensioniView = new VideogiochiListView();
            _videogiochiView = new VideogiochiListView();
            _userProfileView = new UserProfileView();

            _logSignInView = new LogSignInView();

            _recensioniView.GetCustomDataGrid().CellClicked += onVideogiocoSelected;
            _videogiochiView.GetCustomDataGrid().CellClicked += onVideogiocoSelected;
            _userProfileView.Logout += _utente_Logout;

            // hack per partire dalla schermata delle recensioni
            //_recensioniButton_Click(null, EventArgs.Empty);
            _utente_Login(null, EventArgs.Empty);

            new VideogiochiPresenter(_videogiochiView, _sessione);
            new VideogiochiRecensitiPresenter(_recensioniView, _sessione);
            new UtentePresenter(_userProfileView, _sessione);
            new LogSignInPresenter(_logSignInView, _sessione).Login+=_utente_Profilo;
            ToolbarPresenter toolbarPresenter = new ToolbarPresenter(_utenteButton, _sessione);
            
            toolbarPresenter.LoginUtente += this._utente_Login;
            toolbarPresenter.ProfiloUtente += this._utente_Profilo;

            TestoBottoneUtenteLogin();
        }

        // scatta quando si seleziona un item dalla lista. Fa vedere la vista dettagliata del videogioco e della relativa recensione (se presente)
        private void onVideogiocoSelected(Object selectedObject)
        {
            //String nomeGiocoSelezionato = nomeVidegioco; //_rowsVideogiochi[((DataGridViewCellEventArgs)e).RowIndex][0];

            if(_videogiocoPresenter==null)
            {
                _videogiocoPresenter = new VideogiocoPresenter((Videogioco) selectedObject, _sessione);
            }
            else
            {
                _videogiocoPresenter.Videogioco = (Videogioco) selectedObject;
            }

            _viewsContainer.Controls.Remove(_currentControl);
            _viewsContainer.Controls.Add(_videogiocoPresenter.View);

            _currentControl = _videogiocoPresenter.View;
        }

        private void _recensioniButton_Click(object sender, EventArgs e)
        {
            if (_currentControl != _recensioniView)
            {
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_recensioniView);

                // le windows form fanno schifo
                //_recensioniButton.BackColor = Color.FromArgb(25, 118, 210);

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

        private void _utente_Login(object sender, EventArgs e)
        {

            if (_currentControl != _logSignInView)
            {
                TestoBottoneUtenteLogin();
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_logSignInView);

                _currentControl = _logSignInView;
            }
        }

        private void _utente_Logout(object sender, EventArgs e)
        {
            TestoBottoneUtenteLogin();
            _viewsContainer.Controls.Remove(_currentControl);
            _viewsContainer.Controls.Add(_logSignInView);

            _currentControl = _logSignInView;
        }


        private void _utente_Profilo(object sender, EventArgs e)
        {

            if (_currentControl != _userProfileView)
            {
                TestoBottoneUtenteLogin();
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(_userProfileView);

                _currentControl = _userProfileView;
            }
        }

        private void TestoBottoneUtenteLogin()
        {
            if(_sessione.UtenteCorrente!=null)
                _utenteButton.Text = "Utente";
            else
                _utenteButton.Text = "Login";
        }

        private void _newSessionButton_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
        }
    }
}
