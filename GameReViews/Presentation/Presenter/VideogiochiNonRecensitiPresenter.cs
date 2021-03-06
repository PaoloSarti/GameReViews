﻿using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Presentation.View;

namespace GameReViews.Presentation.Presenter
{
    public class VideogiochiNonRecensitiPresenter : VideogiochiPresenter
    {

        public VideogiochiNonRecensitiPresenter(Sessione sessione) : base( sessione)
        {
            _view.GetAggiungiVideogiocoButton().Click += _aggiungiVideogiocoButton_Click;

            //mi registro al cambiamento della sessione
            _sessione.Changed += Sessione_Changed;

            //verifico lo stato della sessione
            Sessione_Changed(null, EventArgs.Empty);

        } 

        protected override BindingSource GetBindingSource()
        {
            IList<Videogioco> videogiochi = Document.GetInstance().Videogiochi.List.Where(videogioco => videogioco.Recensione == null).ToList();
            BindingList<Videogioco> bindingList = new BindingList<Videogioco>(videogiochi);



            return new BindingSource(bindingList, null);
        }

        private void _aggiungiVideogiocoButton_Click(object sender, EventArgs e)
        {
            AggiungiVideogioco addVideogiocoView = new AggiungiVideogioco();
            if (addVideogiocoView.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Videogioco videogioco = new Videogioco(addVideogiocoView.Nome, addVideogiocoView.DataRilascio, addVideogiocoView.Genere, addVideogiocoView.Image);

                    Document.GetInstance().Videogiochi.AddVideogioco(videogioco);
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossibile inserire il videogioco", "ERRORE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
        }

        private void Sessione_Changed(object sender, EventArgs e)
        {
            //solo se l'utente corrente si è loggato può aggiungere videogiochi
            _view.GetAggiungiVideogiocoButton().Visible = _sessione.UtenteCorrente!=null;
        }

    }
}
