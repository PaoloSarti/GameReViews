using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    class UtentePresenter
    {
        private UserProfileView _userProfileView;

        public UtentePresenter(UserProfileView userProfileView)
        {
            _userProfileView = userProfileView;

            BindData();
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
            IList<AspettoValore> preferenze = Document.GetInstance().UtenteCorrente.Preferenze.List.ToList();
            BindingList<AspettoValore> bindingList = new BindingList<AspettoValore>(preferenze);

            return new BindingSource(bindingList, null);
        }


        private void Preferenze_Changed(object sender, EventArgs e)
        {
            _userProfileView.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            _userProfileView.Refresh();
        }




    }
}
