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
    public partial class LogSignInView : UserControl
    {
        public event EventHandler LoginButtonClick;

        public event EventHandler SignInButtonClick;

        public LogSignInView()
        {
            InitializeComponent();
        }

        public String NomeUtente
        {
            get
            {
                return _usernameTextBox.Text;
            }
        }

        public String Password
        {
            get
            {
                return _passwordTextBox.Text;
            }
        }

        #region eventi

        private void _loginButton_Click(object sender, EventArgs e)
        {
            if (LoginButtonClick != null)
            {
                LoginButtonClick(null, EventArgs.Empty);
            }
        }

        private void _signinButton_Click(object sender, EventArgs e)
        {
            if (SignInButtonClick != null)
            {
                SignInButtonClick(null, EventArgs.Empty);
            }
        }

        #endregion

    }
}
