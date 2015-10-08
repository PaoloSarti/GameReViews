using System;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.View
{
    public partial class VideogiocoRootView : UserControl
    {
        private Videogioco _videogioco;
        private UserControl _currentDetailView;

        public event EventHandler EliminaVideogioco;

        private VideogiocoRootView()
        {
            InitializeComponent();
        }

        public VideogiocoRootView(Videogioco videogioco, UserControl detailView) : this()
        {
            _videogioco = videogioco;

            UpdateVideogiocoView(detailView);
        }

        public void abilitaEliminaButton(bool value)
        {
            _eliminaButton.Visible = value;
        }

        public void UpdateVideogiocoView(UserControl detailView)
        {
            _nomeVideogiocoLabel.Text = _videogioco.Nome;
            _dataVideogiocoLabel.Text = _videogioco.DataRilascio.ToShortDateString();
            _genereVideogiocoLabel.Text = _videogioco.Genere.ToString();

            if (_videogioco.Image != null)
                _immagineVideogioco.Image = _videogioco.Image;
            else
                _immagineVideogioco.Image = GameReViews.Properties.Resources.ic_insert_photo_white_48dp;

            this.Dock = DockStyle.Fill;

            // ----

            if (_currentDetailView != null)
                _recensioneContainer.Controls.Remove(_currentDetailView);

            _currentDetailView = detailView;
            _recensioneContainer.Controls.Add(detailView);
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
            }
        }

        private void _eliminaButton_Click(object sender, EventArgs e)
        {
            if (EliminaVideogioco != null)
                EliminaVideogioco(null, EventArgs.Empty);
        }
    }
}
