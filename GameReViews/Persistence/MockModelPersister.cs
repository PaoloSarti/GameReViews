using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GameReViews.Model;


namespace GameReViews.Persistence
{
    class MockModelPersister : IModelPersister
    {
        public IModelLoader GetLoader()
        {
            throw new NotImplementedException();
        }

        public void Save(Model.Model model)
        {
            //nel Mock non salvo nulla
            return;
        }
    }

    class MockModelLoader : IModelLoader
    {
        Videogiochi _videogiochi;
        Recensioni _recensioni;
        UtentiRegistrati _utenti;

        public MockModelLoader()
        {
            //aggiungo qualche utente
            UtenteRegistrato u1 = new UtenteRegistrato("utente1", "password1");
            UtenteRegistrato u2 = new UtenteRegistrato("utente2", "password2");
            UtenteRegistrato u3 = new UtenteRegistrato("utente3", "password3");
            UtenteRegistrato u4 = new UtenteRegistrato("utente4", "password4");

            //aggiungo qualche recensore
            Recensore r1 = new Recensore("recensore1", "password5");
            Recensore r2 = new Recensore("recensore2", "password6");
            Recensore r3 = new Recensore("recensore3", "password7");

            //aggiungo qualche videogioco
            Videogioco v1 = new Videogioco("Videogioco1", DateTime.Now, Genere.AZIONE);
            Videogioco v2 = new Videogioco("Videogioco2", DateTime.Now, Genere.FANTASY);
            Videogioco v3 = new Videogioco("Videogioco3", DateTime.Now, Genere.HORROR);
            Videogioco v4 = new Videogioco("Videogioco4", DateTime.Now, Genere.AZIONE);
            Videogioco v5 = new Videogioco("Videogioco5", DateTime.Now, Genere.AZIONE);
            Videogioco v6 = new Videogioco("Videogioco6", DateTime.Now, Genere.AZIONE);
            Videogioco v7 = new Videogioco("Videogioco7", DateTime.Now, Genere.AZIONE);

            //aggiungo qualche recensione
            //il costruttore di recensione aggiorna automaticamente il riferimento in videogioco
            Recensione re1 = new Recensione(v1, "testo lunghissimo1", r1);
            Recensione re2 = new Recensione(v2, "testo lunghissimo2", r1);
            Recensione re3 = new Recensione(v3, "testo lunghissimo3", r2);
            Recensione re4 = new Recensione(v4, "testo lunghissimo4", r3);

            //aggiungo aspetti valutati alle recensioni (viene popolata anche la classe Aspetti del Model)
            re1.AddAspettoValutato(new Aspetto("aspetto1", "descrizione1"), 8);
            re1.AddAspettoValutato(new Aspetto("aspetto2", "descrizione2"), 4);
            re1.AddAspettoValutato(new Aspetto("aspetto3", "descrizione3"), 5);

            re2.AddAspettoValutato(new Aspetto("aspetto1", "descrizione1"), 6);
            re2.AddAspettoValutato(new Aspetto("aspetto3", "descrizione3"), 7);

            re3.AddAspettoValutato(new Aspetto("aspetto4", "descrizione4"), 6);
            re3.AddAspettoValutato(new Aspetto("aspetto2", "descrizione2"), 7);

            re4.AddAspettoValutato(new Aspetto("aspetto1", "descrizione1"), 3);
            re4.AddAspettoValutato(new Aspetto("aspetto3", "descrizione3"), 10);
            re4.AddAspettoValutato(new Aspetto("aspetto5", "descrizione5"), 2);

            //aggiungo preferenze agli utenti/recensori
            u1.AddPreferenza(new Aspetto("aspetto1"), 2);
            //da completare....

            this._utenti = new UtentiRegistrati();
            throw new NotImplementedException();


        }

        public Videogiochi LoadVideogiochi()
        {
            return this._videogiochi;
        }

        public Recensioni LoadRecensioni()
        {
            return this._recensioni;
        }

        public UtentiRegistrati LoadUtentiRegistrati()
        {
            return this._utenti;
        }
    }

}
