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
            return new MockModelLoader();
        }

        public void Save(Model.Document model)
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
            Initialize_1();
        }

        private void Initialize_1()
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
            Recensione re1 = new Recensione(v1, "testo lunghissimo bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla 1", r1);
            Recensione re2 = new Recensione(v2, "testo lunghissimo bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla 2", r1);
            Recensione re3 = new Recensione(v3, "testo lunghissimo bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla 3", r2);
            Recensione re4 = new Recensione(v4, "testo lunghissimo bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla 4", r3);

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
            u1.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 2);
            u1.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 4);
            u1.AddPreferenza(new Aspetto("aspetto3", "descrizione3"), 2);
            u1.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 6);

            u2.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 2);
            u2.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 1);
            u2.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 7);
            u2.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 2);

            u3.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 4);
            u3.AddPreferenza(new Aspetto("aspetto3", "descrizione3"), 1);
            u3.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 2);
            u3.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 5);

            u4.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 10);
            u4.AddPreferenza(new Aspetto("aspetto2", "descrizione3"), 3);
            u4.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 0);

            r1.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 8);
            r1.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 4);
            r1.AddPreferenza(new Aspetto("aspetto3", "descrizione3"), 1);
            r1.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 2);
            r1.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 5);

            r2.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 8);
            r2.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 4);
            r2.AddPreferenza(new Aspetto("aspetto3", "descrizione3"), 7);
            r2.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 2);
            r2.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 5);

            r3.AddPreferenza(new Aspetto("aspetto1", "descrizione1"), 7);
            r3.AddPreferenza(new Aspetto("aspetto2", "descrizione2"), 4);
            r3.AddPreferenza(new Aspetto("aspetto3", "descrizione3"), 1);
            r3.AddPreferenza(new Aspetto("aspetto4", "descrizione4"), 2);
            r3.AddPreferenza(new Aspetto("aspetto5", "descrizione5"), 5);

            //aggiungo un paio di commenti
            re1.InserisciCommento("commento1", u1);
            foreach(Commento c in re1.Commenti)
            {
                c.Rispondi("risposta1", u2);
                c.Rispondi("risposta2", u4);
            }

            HashSet<UtenteRegistrato> utenti = new HashSet<UtenteRegistrato>();
            utenti.Add(u1);
            utenti.Add(u2);
            utenti.Add(u3);
            utenti.Add(u4);
            utenti.Add(r1);
            utenti.Add(r2);
            utenti.Add(r3);

            this._utenti = new UtentiRegistrati(utenti);

            this._videogiochi = new Videogiochi();
            _videogiochi.AddVideogioco(v1);
            _videogiochi.AddVideogioco(v2);
            _videogiochi.AddVideogioco(v3);
            _videogiochi.AddVideogioco(v4);
            _videogiochi.AddVideogioco(v5);
            _videogiochi.AddVideogioco(v6);
            _videogiochi.AddVideogioco(v7);

            this._recensioni = new Recensioni();
            _recensioni.AddRecensione(re1);
            _recensioni.AddRecensione(re2);
            _recensioni.AddRecensione(re3);
            _recensioni.AddRecensione(re4);
        }


        public Videogiochi GetVideogiochi()
        {
            return this._videogiochi;
        }

        public Recensioni GetRecensioni()
        {
            return this._recensioni;
        }

        public UtentiRegistrati GetUtentiRegistrati()
        {
            return this._utenti;
        }
    }

}
