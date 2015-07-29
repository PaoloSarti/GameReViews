using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    /**classe contenitore per gli utenti e recensori memorizzati nel sistema,
     * con metodi per il login (semplice verifica della presenza nel sistema e restituzione del riferimento)
     * e registrazione (aggiunta di un nuovo utente/recensore)
     */
    public class UtentiRegistrati
    {
        private HashSet<UtenteRegistrato> _utenti;

        public UtentiRegistrati()
        {
            this._utenti = new HashSet<UtenteRegistrato>();
        }

        public UtentiRegistrati(HashSet<UtenteRegistrato> utenti)
        {
            #region Precondizioni
            if (utenti == null)
                throw new ArgumentNullException("utenti == null");
            #endregion

            this._utenti = utenti;
        }

        //restituisce l'IEnumerable di utenti
        public IEnumerable<UtenteRegistrato> List
        {
            get { return _utenti; }
        }

        /* Verifica la presenza nella collezione dell'utente e ne restituisce il riferimento, altrimenti lancia eccezione
         * 
         */
        public UtenteRegistrato Autentica(String nome, String password)
        {
            #region Precondizioni
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(password))
                throw new ArgumentException("String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(password)");
            #endregion

            foreach(UtenteRegistrato u in _utenti)
            {
                if((u.Nome == nome) && (u.Password == password))
                {
                    return u;
                }
            }

            throw new ArgumentException("Utente non presente nel sistema");
        }

        public void Registra(UtenteRegistrato utente)
        {
            #region Precondizioni
            if (utente == null)
                throw new ArgumentNullException("utente == null");


            #endregion

            //se l'utente è già registrato, lancio eccezione
            if(!_utenti.Add(utente))
                throw new ArgumentException("!_utenti.Add(utente)");
        }

    }
}
