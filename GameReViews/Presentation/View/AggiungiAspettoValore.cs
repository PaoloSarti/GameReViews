using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*
 * 
 * 
 * 
 */
namespace GameReViews.Presentation.View
{
    public partial class AggiungiAspettoValore : Form
    {
        private IEnumerable<Aspetto> _aspetti;


        public AggiungiAspettoValore(IEnumerable<Aspetto> aspetti)
        {
            InitializeComponent();
            this._aspetti = aspetti;

            foreach(Aspetto aspetto in aspetti)
            {
                _aspettiCombo.Items.Add(aspetto.Nome);
            }

            _aspettiCombo.SelectedIndex = 0;
            _valutazione.Maximum = 10;
            _valutazione.Minimum = 0;

        }

        public Aspetto AspettoSelezionato
        {
            get
            {

                foreach(Aspetto aspetto in _aspetti)
                {


                    if ((aspetto.Nome == (String)_aspettiCombo.SelectedItem))
                        return aspetto;
                }

                throw new Exception();
            }
        }

        public int Valutazione
        {
            get
            {
                return (int) _valutazione.Value;
            }
        }


    }
}
