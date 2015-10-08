using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using GameReViews.Model;

namespace GameReViews.View
{
    public partial class VideogiocoRecensioneView : UserControl
    {
        private Videogioco _videogioco;

        public event EventHandler ValutaAspettoClick;

        private VideogiocoRecensioneView()
        {
            InitializeComponent();
        }

        public VideogiocoRecensioneView(Videogioco videogioco, float valutazione) : this()
        {
            _videogioco = videogioco;
            this.Dock = DockStyle.Fill;

            BindData();

            _recensioneText.Text = videogioco.Recensione.Testo;
            _valutazione.Text = valutazione +"";
            _recensoreLabel.Text = videogioco.Recensione.Autore.Nome;
        }

        public void DisabilitaValutaAspettoButton(bool value)
        {
            _valutaAspettoButton.Visible = !value;
        }

        private void BindData()
        {
            string[][] headersAspetti = new string[2][];

            //Per far funzionare KeyValuePair, bisogna indicare i nomi delle proprietà: key e value
            headersAspetti[0] = new string[2] { "Aspetto", "aspetto" };
            headersAspetti[1] = new string[2] { "Valutazione/Peso", "valore" };

            IList<AspettoValutato> aspettiValutati = _videogioco.Recensione.AspettiValutati.ToList();
            BindingList<AspettoValutato> bindingListPreferenze = new BindingList<AspettoValutato>(aspettiValutati);
            BindingSource source_preferenze = new BindingSource(bindingListPreferenze, null);
            

            _customDataGridView.InitDataSource(source_preferenze, headersAspetti);
        }

        public CustomDataGridView GetCustomDataGrid()
        {
            return _customDataGridView;
        }

        private void _valutaAspettoButton_Click(object sender, EventArgs e)
        {
            if (ValutaAspettoClick != null)
                ValutaAspettoClick(null, EventArgs.Empty);
        }

    }
}
