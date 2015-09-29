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

        public event EventHandler AggiuntaRecensione;

        public event EventHandler ValutaAspetto;

        public event CellClickedDelegate ModificaValutazione;

        public event EventHandler EliminaVideogioco;

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
            this.Dock = DockStyle.Fill;

            if (_sessione.UtenteCorrente is Recensore)
                _eliminaButton.Visible = true;
            else
                _eliminaButton.Visible = false;


            if (_videogioco.Recensione == null)
            {
                VideogiocoNoReviewDetailView recensioneView = new VideogiocoNoReviewDetailView(_sessione);
                recensioneView.Dock = DockStyle.Fill;

                if (_currentDetailView != null)
                {
                    _recensioneContainer.Controls.Remove(_currentDetailView);
                    if(_currentDetailView is VideogiocoNoReviewDetailView)
                    {
                        //deregistrazione per evitare di mantenere il riferimento in memoria
                        VideogiocoNoReviewDetailView view = (VideogiocoNoReviewDetailView)_currentDetailView;
                        view.aggiuntaRecensione -= recensioneView_aggiuntaRecensione;
                    }
                }

                _currentDetailView = recensioneView;

                recensioneView.aggiuntaRecensione += recensioneView_aggiuntaRecensione;

                _recensioneContainer.Controls.Add(recensioneView);
            }
            else
            {
                VideogiocoYesReviewDetailView recensioneView = new VideogiocoYesReviewDetailView(_videogioco, _sessione);

                if(_currentDetailView is VideogiocoYesReviewDetailView)
                {
                    //deregistrazione per evitare di mantenere il riferimento in memoria
                    VideogiocoYesReviewDetailView view = (VideogiocoYesReviewDetailView)_currentDetailView;
                    view.ValutaAspettoClick -= recensioneView_ValutaAspettoClick;
                    view.GetCustomDataGrid().CellClicked -= VideogiocoRootView_CellClicked;
                }

                if (_currentDetailView != null)
                    _recensioneContainer.Controls.Remove(_currentDetailView);

                recensioneView.ValutaAspettoClick += recensioneView_ValutaAspettoClick;

                recensioneView.GetCustomDataGrid().CellClicked += VideogiocoRootView_CellClicked;

                _currentDetailView = recensioneView;

                _recensioneContainer.Controls.Add(recensioneView);
            }

        }

        void VideogiocoRootView_CellClicked(object selectedObject)
        {
            if (ModificaValutazione != null && _sessione.UtenteCorrente!=null && _sessione.UtenteCorrente.Nome==_videogioco.Recensione.Autore.Nome)
                ModificaValutazione(selectedObject);
        }

        void recensioneView_ValutaAspettoClick(object sender, EventArgs e)
        {
            if (ValutaAspetto != null && _sessione.UtenteCorrente != null && _sessione.UtenteCorrente.Nome == _videogioco.Recensione.Autore.Nome)
                ValutaAspetto(null, EventArgs.Empty);
        }

        void recensioneView_aggiuntaRecensione(object sender, EventArgs e)
        {
            if (AggiuntaRecensione != null)
                AggiuntaRecensione(null, EventArgs.Empty);
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

        private void _eliminaButton_Click(object sender, EventArgs e)
        {
            if (EliminaVideogioco != null)
                EliminaVideogioco(null, EventArgs.Empty);
        }
    }
}
