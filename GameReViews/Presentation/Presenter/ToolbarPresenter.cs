using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameReViews.Presentation.Presenter
{
    public class ToolbarPresenter
    {
        Button _utenteButton;

        public event EventHandler LoginUtente;
        public event EventHandler ProfiloUtente;

        private Sessione _sessione;

        public ToolbarPresenter(Button utenteButton, Sessione sessione)
        {
            _utenteButton = utenteButton;
            _utenteButton.Click += UtenteButton_click;

            _sessione = sessione;
        }

        private void UtenteButton_click(object sender, EventArgs e)
        {
            if(_sessione.UtenteCorrente == null)
            {
                if (LoginUtente != null)
                    LoginUtente(null, EventArgs.Empty);
            }
            else
            {
                if (ProfiloUtente != null)
                    ProfiloUtente(null, EventArgs.Empty);
            }
        }
    }
}
