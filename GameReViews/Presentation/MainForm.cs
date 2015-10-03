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

        private VideogiochiNonRecensitiPresenter _videogiochiPresenter;
        private VideogiochiRecensitiPresenter _videogiochiRecensitiPresenter;
        private UtentePresenter _utentePresenter;
        private LogSignInPresenter _logSignInPresenter;
        private VideogiocoPresenter _videogiocoPresenter;

        private Sessione _sessione;

        public MainForm()
        {
            InitializeComponent();

            _sessione = new Sessione();

            _videogiochiPresenter = new VideogiochiNonRecensitiPresenter(_sessione);
            _videogiochiRecensitiPresenter = new VideogiochiRecensitiPresenter(_sessione);
            _utentePresenter = new UtentePresenter(_sessione);
            _logSignInPresenter = new LogSignInPresenter(_sessione);
            
            //registrazione agli eventi per cambiare la view corrente
            _videogiochiRecensitiPresenter.CellClicked += OnVideogiocoSelected;
            _videogiochiPresenter.CellClicked += OnVideogiocoSelected;

            _utentePresenter.Logout += _utente_Logout;
            _logSignInPresenter.Login += _utente_Profilo;

            //Parto dal login
            _utente_Login(null, EventArgs.Empty);

            UpdateTestoBottoneUtenteLogin();
        }

        // scatta quando si seleziona un item dalla lista. Fa vedere la vista dettagliata del videogioco e della relativa recensione (se presente)
        private void OnVideogiocoSelected(Object selectedObject)
        {
            
            if(_videogiocoPresenter==null)
            {
                _videogiocoPresenter = new VideogiocoPresenter((Videogioco) selectedObject, _sessione);

                _videogiocoPresenter.EliminaVideogioco += _videogiochiButton_Click;
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
            _videogiochiRecensitiPresenter.VideogiochiList_Changed(null, e);
            ChangeView(_videogiochiRecensitiPresenter.View);
        }

        private void _videogiochiButton_Click(object sender, EventArgs e)
        {
            _videogiochiPresenter.VideogiochiList_Changed(null, e);
            ChangeView(_videogiochiPresenter.View);
        }

        private void _utente_Login(object sender, EventArgs e)
        {
            ChangeView(_logSignInPresenter.View);
        }

        private void _utente_Logout(object sender, EventArgs e)
        {
            ChangeView(_logSignInPresenter.View);
        }


        private void _utente_Profilo(object sender, EventArgs e)
        {
            ChangeView(_utentePresenter.View);
        }

        private void ChangeView(Control view)
        {
            if (_currentControl != view)
            {
                UpdateTestoBottoneUtenteLogin();
                _viewsContainer.Controls.Remove(_currentControl);
                _viewsContainer.Controls.Add(view);

                _currentControl = view;
            }
        }

        private void UpdateTestoBottoneUtenteLogin()
        {
            if(_sessione.UtenteCorrente!=null)
                _utenteButton.Text = "Utente";
            else
                _utenteButton.Text = "Accesso";
        }

        private void _newSessionButton_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
        }

        private void _utenteButton_Click(object sender, EventArgs e)
        {
            if (_sessione.UtenteCorrente == null)
            {
                ChangeView(_logSignInPresenter.View);
            }
            else
            {
                ChangeView(_utentePresenter.View);
            }
        }
    }
}
