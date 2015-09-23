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

        private Sessione _sessione;

        private UserControl _currentDetailView;

        private VideogiocoRootView()
        {
            InitializeComponent();
        }


        public VideogiocoRootView(Videogioco videogioco, Sessione sessione) : this()
        {
            _videogioco = videogioco;

            _sessione = sessione;

            UpdateVideogiocoView();
        }

        private void UpdateVideogiocoView()
        {
            _nomeVideogiocoLabel.Text = _videogioco.Nome;
            _dataVideogiocoLabel.Text = _videogioco.DataRilascio.ToString();
            _genereVideogiocoLabel.Text = _videogioco.Genere.ToString();
            _immagineVideogioco.Image = _videogioco.Image;

            if (_videogioco.Recensione == null)
            {
                VideogiocoNoReviewDetailView recensioneView = new VideogiocoNoReviewDetailView(_sessione);
                recensioneView.Dock = DockStyle.Fill;


                if (_currentDetailView != null)
                    _recensioneContainer.Controls.Remove(_currentDetailView);

                _currentDetailView = recensioneView;

                _recensioneContainer.Controls.Add(recensioneView);
            }
            else
            {
                VideogiocoYesReviewDetailView recensioneView = new VideogiocoYesReviewDetailView(_videogioco, _sessione);
                recensioneView.Dock = DockStyle.Fill;

                if (_currentDetailView != null)
                    _recensioneContainer.Controls.Remove(_currentDetailView);

                _currentDetailView = recensioneView;

                _recensioneContainer.Controls.Add(recensioneView);
            }


        }



        public Videogioco Videogioco
        {
            get
            {
                return _videogioco;
            }
            set
            {
                _videogioco = value;
                this.UpdateVideogiocoView();
            }
        }
    }
}
