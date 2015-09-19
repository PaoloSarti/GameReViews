using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    public abstract class AbstractVideogiochiPresenter
    {
        protected VideogiochiListView _videogiochiView;
        protected Sessione _sessione;

        public AbstractVideogiochiPresenter(VideogiochiListView videogichiView, Sessione sessione)
        {
            _videogiochiView = videogichiView;
            _sessione = sessione;

            _videogiochiView.Dock = DockStyle.Fill;

            BindData();

            Document.GetInstance().Videogiochi.VideogiochiChanged += VideogiochiList_Changed;
        }

        private void BindData()
        {
            // videogiochi (e recensioni)
            string[][] headers = new string[3][];
            headers[0] = new string[2] { "Nome Gioco", "nome" };
            headers[1] = new string[2] { "Data Rilascio", "dataRilascio" };
            headers[2] = new string[2] { "Genere", "genere" };

            BindingSource source = GetBindingSource();

            _videogiochiView.GetCustomDataGrid().InitDataSource(source, headers);
        }

        private void VideogiochiList_Changed(object sender, EventArgs e)
        {
            _videogiochiView.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            _videogiochiView.Refresh();
        }

        //Template Method
        protected abstract BindingSource GetBindingSource();

    }
}
