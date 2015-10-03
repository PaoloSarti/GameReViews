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
        protected VideogiochiListView _view;

        protected Sessione _sessione;

        public event CellClickedDelegate CellClicked;

        public AbstractVideogiochiPresenter(Sessione sessione)
        {
            _view = new VideogiochiListView();
            _sessione = sessione;

            _view.Dock = DockStyle.Fill;

            BindData();

            Document.GetInstance().Videogiochi.VideogiochiChanged += VideogiochiList_Changed;

            _view.GetCustomDataGrid().CellClicked += AbstractVideogiochiPresenter_CellClicked;
        }

        void AbstractVideogiochiPresenter_CellClicked(object selectedObject)
        {
            if(CellClicked!=null)
                CellClicked(selectedObject);
        }

        private void BindData()
        {
            // videogiochi (e recensioni)
            string[][] headers = new string[3][];
            headers[0] = new string[2] { "Nome Gioco", "nome" };
            headers[1] = new string[2] { "Data Rilascio", "dataRilascio" };
            headers[2] = new string[2] { "Genere", "genere" };

            BindingSource source = GetBindingSource();

            _view.GetCustomDataGrid().InitDataSource(source, headers);
        }

        public void VideogiochiList_Changed(object sender, EventArgs e)
        {
            _view.GetCustomDataGrid().UpdateDataSource(GetBindingSource());
            _view.Refresh();
        }

        public Control View
        {
            get { return _view; }
        }

        //Template Method
        protected abstract BindingSource GetBindingSource();

    }
}
