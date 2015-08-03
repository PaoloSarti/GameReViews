using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    public class VideogiochiRecensitiPresenter : AbstractVideogiochiPresenter
    {

        public VideogiochiRecensitiPresenter(VideogiochiListView videogichiView)
            : base(videogichiView)
        {
            videogichiView.GetAggiungiVideogiocoButton().Visible = false;
        }

        protected override BindingSource GetBindingSource()
        {
            IList<Videogioco> videogiochi = Document.GetInstance().Videogiochi.VideogiochiRecensiti.ToList();
            BindingList<Videogioco> bindingList = new BindingList<Videogioco>(videogiochi);

            return new BindingSource(bindingList, null);
        }
    }
}
