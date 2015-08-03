using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    public class VideogiochiPresenter : AbstractVideogiochiPresenter
    {

        public VideogiochiPresenter(VideogiochiListView videogichiView) : base(videogichiView)
        {
            _videogiochiView.GetAggiungiVideogiocoButton().Click += _aggiungiVideogiocoButton_Click;
        } 

        protected override BindingSource GetBindingSource()
        {
            IList<Videogioco> videogiochi = Document.GetInstance().Videogiochi.List.ToList();
            BindingList<Videogioco> bindingList = new BindingList<Videogioco>(videogiochi);

            return new BindingSource(bindingList, null);
        }

        private void _aggiungiVideogiocoButton_Click(object sender, EventArgs e)
        {
            Document.GetInstance().Videogiochi.AddVideogioco(new Videogioco("USUSUGDSAIDGSAJKDGBA", DateTime.Now, Genere.AZIONE));
        }
    }
}
