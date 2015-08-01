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
    public partial class VideogiocoYesReviewDetailView : UserControl
    {
        private Videogioco _videogioco;

        private VideogiocoYesReviewDetailView()
        {
            InitializeComponent();
        }

        public VideogiocoYesReviewDetailView(Videogioco videogioco) : this()
        {
            _videogioco = videogioco;
        }
    }
}
