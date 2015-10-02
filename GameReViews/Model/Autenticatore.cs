using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    /**
     * Classe concreta per l'autenticazione
     * con metodi per il login (semplice verifica della presenza nel sistema e restituzione del riferimento)
     * e registrazione (aggiunta di un nuovo utente/recensore)
     * 
     * Realizzata semplicemente mantenendo il riferimento alla lista delle istanze degli utenti 
     * 
     */
    public class Autenticatore : IAutenticatore
    {
        private HashSet<UtenteRegistrato> _utenti;

        public Autenticatore()
        {
            this._utenti = new HashSet<UtenteRegistrato>();
        }

        public Autenticatore(HashSet<UtenteRegistrato> utenti)
        {
            #region Precondizioni
            if (utenti == null)
                throw new ArgumentNullException("utenti == null");
            #endregion

            this._utenti = utenti;
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
                throw new ArgumentException("Utente già registrato nel sistema");
        }


    }
}
