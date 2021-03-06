﻿using GameReViews.Model;
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
        private UtenteView _view;

        private Sessione _sessione;

        public event EventHandler Logout;

        public UtentePresenter(Sessione sessione)
        {
            _view = new UtenteView();

            _view.Dock = DockStyle.Fill;

            _sessione = sessione;

            _sessione.Changed += Sessione_Changed;

            _view.Logout += _view_Logout;

            _view.AggiungiPreferenza += AggiungiPreferenza;

            _view.GetCustomDataGrid().CellClicked += UtentePresenter_CellClicked;

        }

        void _view_Logout(object sender, EventArgs e)
        {
            _sessione.Logout();
            if (Logout != null)
                Logout(null, EventArgs.Empty);
        }

        void UtentePresenter_CellClicked(object selectedObject)
        {
            AspettoValore aspettoValore = (AspettoValore)selectedObject;
            //Console.WriteLine(aspettoValore.Aspetto.Nome + " " +aspettoValore.Aspetto.Descrizione +" " +aspettoValore.Valore);

            ModificaEliminaValutazione dialog = new ModificaEliminaValutazione(aspettoValore);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(dialog.Elimina==true)
                    {
                        _sessione.UtenteCorrente.RemovePreferenza(aspettoValore.Aspetto);
                    }
                    else
                    {
                        _sessione.UtenteCorrente.ModificaPreferenza(aspettoValore.Aspetto, dialog.Valore);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Impossibile modificare/eliminare la preferenza", "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void UpdateData()
        {
            string[][] headersPreferenze = new string[2][];

            /*
            headersPreferenze[0] = new string[2] { "Aspetto", "aspetto" };
            headersPreferenze[1] = new string[2] { "Valutazione/Peso", "valore" };
            */
             
            BindingSource source = GetBindingSource();

            _view.GetCustomDataGrid().UpdateDataSource(source);
        }


        protected BindingSource GetBindingSource()
        {
            IList<Preferenza> preferenze = _sessione.UtenteCorrente.Preferenze.ToList();
            BindingList<Preferenza> bindingList = new BindingList<Preferenza>(preferenze);

            return new BindingSource(bindingList, null);
        }

        private void AggiungiPreferenza(object sender, EventArgs e)
        {

            //Prendo gli aspetti che non sono contenuti già nelle preferenze
            List<Aspetto> aspettiPreferenze = (from aspettoValore in _sessione.UtenteCorrente.Preferenze.ToList() select aspettoValore.Aspetto).ToList();

            IEnumerable<Aspetto> aspetti = Document.GetInstance().Aspetti.List.Where(aspetto => !aspettiPreferenze.Contains(aspetto));

            if(aspetti.Count()==0)
            {
                MessageBox.Show("Hai già inserito tutte le preferenze", "ERRORE",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            AggiungiAspettoValore aggiungiAspettoValoreView = new AggiungiAspettoValore(aspetti);
            if (aggiungiAspettoValoreView.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Aspetto aspettoSelezionato = aggiungiAspettoValoreView.AspettoSelezionato;
                    int valutazione = aggiungiAspettoValoreView.Valutazione;

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
                _view.NomeUtente = _sessione.UtenteCorrente.Nome;

                //_sessione.UtenteCorrente.UtenteChanged+=UtenteCorrente_UtenteChanged;

                UpdateData();
                _view.Refresh();
            }
        }

        public Control View
        {
            get { return _view; }
        }


    }
}
