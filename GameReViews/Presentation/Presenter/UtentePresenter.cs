using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    public class UtentePresenter
    {
        private UserProfileView _userProfileView;

        private Sessione _sessione;

        public UtentePresenter(UserProfileView userProfileView, Sessione sessione)
        {
            _userProfileView = userProfileView;

            _userProfileView.Dock = DockStyle.Fill;

            _sessione = sessione;

            _sessione.SessionChanged += Sessione_Changed;
        }

        private void BindData()
        {
            string[][] headersPreferenze = new string[2][];

            headersPreferenze[0] = new string[2] { "Aspetto", "aspetto" };
            headersPreferenze[1] = new string[2] { "Valutazione/Peso", "valore" };

            BindingSource source = GetBindingSource();

            _userProfileView.GetCustomDataGrid().InitDataSource(source, headersPreferenze);
        }

        protected BindingSource GetBindingSource()
        {
            IList<AspettoValore> preferenze = _sessione.UtenteCorrente.Preferenze.List.ToList();
            BindingList<AspettoValore> bindingList = new BindingList<AspettoValore>(preferenze);

            return new BindingSource(bindingList, null);
        }


        private void Preferenze_Changed(object sender, EventArgs e)
        {
            //_userProfileView.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            BindData();
            _userProfileView.Refresh();
        }

        private void Sessione_Changed(object sender, EventArgs e)
        {
            //_userProfileView.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            if (_sessione.UtenteCorrente != null)
            {
                _userProfileView.NomeUtente = _sessione.UtenteCorrente.Nome;
                BindData();
                _userProfileView.Refresh();
            }
        }


    }
}
