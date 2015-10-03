using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public interface IAutenticatore
    {
        UtenteRegistrato Autentica(String nome, String password);

        void Registra(UtenteRegistrato utente);
    }
}
