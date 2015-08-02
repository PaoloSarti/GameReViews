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

            bindData();
        }

        private void bindData()
        {
            string[][] headersAspetti = new string[2][];

            //Per far funzionare KeyValuePair, bisogna indicare i nomi delle proprietà: key e value
            headersAspetti[0] = new string[2] { "Aspetto", "key" };
            headersAspetti[1] = new string[2] { "Valutazione/Peso", "value" };

            IList<KeyValuePair<Aspetto, int>> aspettiValutati = _videogioco.Recensione.AspettiValutati.AspettiValutati.ToList();
            BindingList<KeyValuePair<Aspetto, int>> bindingListPreferenze = new BindingList<KeyValuePair<Aspetto, int>>(aspettiValutati);
            BindingSource source_preferenze = new BindingSource(bindingListPreferenze, null);
            

            _customDataGridView.setDataSource(source_preferenze, headersAspetti);
        }

        public CustomDataGridView getCustomDataGrid()
        {
            return _customDataGridView;
        }
    }
}
