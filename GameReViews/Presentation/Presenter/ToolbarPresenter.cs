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


        public ToolbarPresenter(Button utenteButton)
        {
            _utenteButton = utenteButton;
            _utenteButton.Click += UtenteButton_click;
        }

        private void UtenteButton_click(object sender, EventArgs e)
        {
            if(Document.GetInstance().UtenteCorrente==null)
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
