using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameReViews.Model;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    class LogSignInPresenter
    {
        public event EventHandler Login;

        private LogSignInView _view;
        private Sessione _sessione;

        public LogSignInPresenter(LogSignInView logSignInView, Sessione sessione)
        {
            _view = logSignInView;
            _sessione = sessione;

            _view.Dock = DockStyle.Fill;

            _view.LoginButtonClick += _login_Button_Click;
            _view.SignInButtonClick += _signin_Button_Click;
        }

        private void _login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                _sessione.Autentica(_view.NomeUtente, _view.Password);

                if (Login != null)
                    Login(null, EventArgs.Empty);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message, "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void _signin_Button_Click(object sender, EventArgs e)
        {
            try
            {
                _sessione.Registra(_view.NomeUtente, _view.Password);
                if (Login != null)
                    Login(null, EventArgs.Empty);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message, "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


    }
}
