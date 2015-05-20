using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameReViews.Model
{
    // TODO: lanciare eccezioni

    // NOTES: in vista di estensioni future (che non faremo, ma vabbè xD) si potrebbe fare una classe astratta/interfaccia 
    // Utente e poi avere UtenteRegistrato che la estente/implementa.
    // In questo modo se un giorno si volesse aggiungere un tipo alla gerarchia di utenti
    // (che per ora è solo UtenteRegistrato e Recensore) si potrebbe fare senza dover modificare "troppo codice"
    // ad esempio: UtenteNonRegistratoChePuoCommentare

    // oppure si prende UtenteRegistrato come base e bona .. e aggiungere UtenteRegistratoCheNonPuoCommentarePercheNero
    public class UtenteRegistrato
    {
        private string _nome;
        private string _password;

        private Image _image;

        private AspettiValutatiManager _aspettiValutatoManager;

        public UtenteRegistrato(string nome, string passowrd)
        {
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(passowrd))
                return; // throws ...

            this._nome = nome;
            this._password = passowrd;

            _aspettiValutatoManager = new AspettiValutatiManager();

            // TODO
            this._image = Image.FromFile("default_image_utente");
        }

        public UtenteRegistrato(string nome, string passowrd, Image image)
            : this(nome, passowrd)
        {
            if (image == null)
                return; // throws ...

            this._image = image;
        }

        // TODO: add methods

        public IEnumerable<AspettoValutato> GetPreferenze()
        {
            return this._aspettiValutatoManager.AspettiValutati;
        }

        public void AddPreferenza(AspettoValutato aspettoValutato)
        {
            this._aspettiValutatoManager.AddAspettoValutato(aspettoValutato);
        }

        public void RemovePreferenza(Aspetto aspetto)
        {
            _aspettiValutatoManager.RemoveAspettoValutato(aspetto);
        }

        public void ModificaPreferenza(Aspetto aspetto, int valutazione)
        {
            _aspettiValutatoManager.ModificaValutazioneAspetto(aspetto, valutazione);
        }
    }
}
