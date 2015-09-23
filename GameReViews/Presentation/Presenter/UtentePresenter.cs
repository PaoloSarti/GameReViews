using GameReViews.Model;
using GameReViews.Presentation.View;
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

            _userProfileView.Logout+=Logout;

            _userProfileView.AggiungiPreferenza += AggiungiPreferenza;
        }

        /*
        private void BindData()
        {
            string[][] headersPreferenze = new string[2][];

            headersPreferenze[0] = new string[2] { "Aspetto", "aspetto" };
            headersPreferenze[1] = new string[2] { "Valutazione/Peso", "valore" };

            BindingSource source = GetBindingSource();

            _userProfileView.GetCustomDataGrid().InitDataSource(source, headersPreferenze);
        }*/

        private void UpdateData()
        {
            string[][] headersPreferenze = new string[2][];

            /*
            headersPreferenze[0] = new string[2] { "Aspetto", "aspetto" };
            headersPreferenze[1] = new string[2] { "Valutazione/Peso", "valore" };
            */
             
            BindingSource source = GetBindingSource();

            _userProfileView.GetCustomDataGrid().UpdateDataSource(source);
        }


        protected BindingSource GetBindingSource()
        {
            IList<AspettoValore> preferenze = _sessione.UtenteCorrente.Preferenze.List.ToList();
            BindingList<AspettoValore> bindingList = new BindingList<AspettoValore>(preferenze);

            return new BindingSource(bindingList, null);
        }

        private void AggiungiPreferenza(object sender, EventArgs e)
        {

            //Prendo gli aspetti che non sono contenuti già nelle preferenze
            List<Aspetto> aspettiPreferenze = (from aspettoValore in _sessione.UtenteCorrente.GetPreferenze().ToList() select aspettoValore.Aspetto).ToList();

            IEnumerable<Aspetto> aspetti = Document.GetInstance().Aspetti.List.Where(aspetto => !aspettiPreferenze.Contains(aspetto));

            AggiungiAspettoValore add = new AggiungiAspettoValore(aspetti);
            if (add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Aspetto aspettoSelezionato = add.AspettoSelezionato;
                    int valutazione = add.Valutazione;

                    if(aspettoSelezionato==null)
                        throw new Exception();

                    _sessione.UtenteCorrente.AddPreferenza(aspettoSelezionato, valutazione);

                }
                catch (Exception)
                {
                    MessageBox.Show("Impossibile inserire la preferenza", "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }


        private void Sessione_Changed(object sender, EventArgs e)
        {
            //_userProfileView.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            if (_sessione.UtenteCorrente != null)
            {
                _userProfileView.NomeUtente = _sessione.UtenteCorrente.Nome;

                _sessione.UtenteCorrente.UtenteChanged+=UtenteCorrente_UtenteChanged;

                UtenteCorrente_UtenteChanged(null, EventArgs.Empty);
            }
        }

        private void UtenteCorrente_UtenteChanged(object sender, EventArgs e)
        {
            UpdateData();
            _userProfileView.Refresh();
        }

        private void Logout(object sender, EventArgs e)
        {
            _sessione.Logout();
        }

    }
}
