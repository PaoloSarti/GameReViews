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
        public VideogiocoRootView()
        {
            InitializeComponent();
        }

        private Videogioco _videogioco;
        private Recensione _recensione;


        public VideogiocoRootView(Videogioco videogiocoSelezionato, Recensione recensione) : this()
        {
            _videogioco = videogiocoSelezionato;
            _recensione = recensione;

            if (recensione == null)
            {
                VideogiocoNoReviewDetailView recensioneView = new VideogiocoNoReviewDetailView();
                recensioneView.Dock = DockStyle.Fill;

                _recensioneContainer.Controls.Add(recensioneView);
            }
            else
            {
                VideogiocoYesReviewDetailView recensioneView = new VideogiocoYesReviewDetailView();
                recensioneView.Dock = DockStyle.Fill;

                _recensioneContainer.Controls.Add(recensioneView);
            }
        }
    }
}
