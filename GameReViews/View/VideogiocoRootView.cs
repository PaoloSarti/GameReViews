using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.View
{
    public partial class VideogiocoRootView : UserControl
    {
        private Videogioco _videogioco;
        private Recensione _recensione;

        private VideogiocoRootView()
        {
            InitializeComponent();
        }


        public VideogiocoRootView(Videogioco videogiocoSelezionato) : this()
        {
            _videogioco = videogiocoSelezionato;
            _recensione = videogiocoSelezionato.Recensione;

            _nomeVideogiocoLabel.Text = videogiocoSelezionato.Nome;
            _dataVideogiocoLabel.Text = videogiocoSelezionato.DataRilascio.ToString();
            _genereVideogiocoLabel.Text = videogiocoSelezionato.Genere.ToString();

            if (_recensione == null)
            {
                VideogiocoNoReviewDetailView recensioneView = new VideogiocoNoReviewDetailView();
                recensioneView.Dock = DockStyle.Fill;

                _recensioneContainer.Controls.Add(recensioneView);
            }
            else
            {
                VideogiocoYesReviewDetailView recensioneView = new VideogiocoYesReviewDetailView(_videogioco);
                recensioneView.Dock = DockStyle.Fill;

                _recensioneContainer.Controls.Add(recensioneView);
            }
        }
    }
}
