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
        public event EventHandler AggiungiPreferenza;

        public event EventHandler Logout;

        public UserProfileView()
        {
            InitializeComponent();
        }

        public CustomDataGridView GetCustomDataGrid()
        {
            return _customDataGridView;
        }

        public String NomeUtente
        {
            get
            {
                return _userName.Text;
            }

            set
            {
                _userName.Text = value;
            }
        }

        private void _aggiungiPreferenza_Click(object sender, EventArgs e)
        {
            if (AggiungiPreferenza != null)
            {
                AggiungiPreferenza(null, EventArgs.Empty);
            }
        }

        private void _logoutButton_Click(object sender, EventArgs e)
        {
            if(this.Logout!=null)
            {
                Logout(null, EventArgs.Empty);
            }
        }



    }
}
