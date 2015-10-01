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
    public partial class VideogiocoRecensioneView : UserControl
    {
        private Videogioco _videogioco;

        private Sessione _sessione;

        public event EventHandler ValutaAspettoClick;

        private VideogiocoRecensioneView()
        {
            InitializeComponent();
        }

        public VideogiocoRecensioneView(Videogioco videogioco, Sessione sessione) : this()
        {
            _videogioco = videogioco;
            this.Dock = DockStyle.Fill;

            BindData();

            _sessione = sessione;

            if (_sessione.UtenteCorrente == null)
                _valutaAspettoButton.Visible = false;
            else if (_sessione.UtenteCorrente!=null && _sessione.UtenteCorrente.Nome!=videogioco.Recensione.Autore.Nome)
            {
                Console.WriteLine("Nome utente: " +_sessione.UtenteCorrente.Nome);
                Console.WriteLine("Nome autore: " + videogioco.Recensione.Autore.Nome);

                _valutaAspettoButton.Visible = false;
            }

            _recensioneText.Text = videogioco.Recensione.Testo;
            _valutazione.Text = _sessione.Calcolo.Calcola(_videogioco.Recensione) + "";
            _recensoreLabel.Text = videogioco.Recensione.Autore.Nome;
        }

        private void BindData()
        {
            string[][] headersAspetti = new string[2][];

            //Per far funzionare KeyValuePair, bisogna indicare i nomi delle proprietà: key e value
            headersAspetti[0] = new string[2] { "Aspetto", "aspetto" };
            headersAspetti[1] = new string[2] { "Valutazione/Peso", "valore" };

            IList<AspettoValore> aspettiValutati = _videogioco.Recensione.AspettiValutati.List.ToList();
            BindingList<AspettoValore> bindingListPreferenze = new BindingList<AspettoValore>(aspettiValutati);
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
