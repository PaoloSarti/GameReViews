using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GameReViews.Model;
using System.Drawing;


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
        Autenticatore _autenticatore;

        public MockModelLoader()
        {
            Initialize_1();
        }

        private void Initialize_1()
        {
            //aggiungo qualche utente
            UtenteRegistrato u1 = new UtenteRegistrato("Filippo", "p");
            UtenteRegistrato u2 = new UtenteRegistrato("Pier", "p");
            UtenteRegistrato u3 = new UtenteRegistrato("Paolo", "p");
            UtenteRegistrato u4 = new UtenteRegistrato("Antonio", "p");

            //aggiungo qualche recensore
            Recensore r1 = new Recensore("Recensore1", "p");
            Recensore r2 = new Recensore("Recensore2", "p");
            Recensore r3 = new Recensore("Recensore3", "p");

            Image image = GameReViews.Properties.Resources.ic_insert_photo_white_48dp;

            //aggiungo qualche videogioco
            Videogioco v1 = new Videogioco("Metal Gear Solid V", DateTime.Now.Date, Genere.STEALTH);
            Videogioco v2 = new Videogioco("No Man's Sky", DateTime.Now.Date, Genere.FANTASY);
            Videogioco v3 = new Videogioco("The Witcher 3", DateTime.Now.Date, Genere.FANTASY);
            Videogioco v4 = new Videogioco("The Elder Scrolls V: Skyrim", DateTime.Now.Date, Genere.FANTASY);
            Videogioco v5 = new Videogioco("Dishonored", DateTime.Now.Date, Genere.STEALTH);
            Videogioco v6 = new Videogioco("Faster Than Light", DateTime.Now.Date, Genere.STRATEGIA);
            Videogioco v7 = new Videogioco("Forza Motorsport 5", DateTime.Now.Date, Genere.CORSE);
            Videogioco v8 = new Videogioco("Super Mario", DateTime.Now.Date, Genere.AVVENTURA);

            //aggiungo qualche recensione
            v1.Recensione = new Recensione("testo recensione", r1);
            v2.Recensione = new Recensione("testo recensione", r1);
            v3.Recensione = new Recensione("testo recensione", r2);
            v4.Recensione = new Recensione("testo recensione", r3);

            //aggiungo aspetti valutati alle recensioni (viene popolata anche la classe Aspetti del Model)
            v1.Recensione.AddAspettoValutato(new Aspetto("grafica", "descrizione1"), 8);
            v1.Recensione.AddAspettoValutato(new Aspetto("giocabilità", "descrizione2"), 4);
            v1.Recensione.AddAspettoValutato(new Aspetto("storia", "descrizione3"), 5);

            v2.Recensione.AddAspettoValutato(new Aspetto("grafica", "descrizione1"), 6);
            v2.Recensione.AddAspettoValutato(new Aspetto("storia", "descrizione3"), 7);

            v3.Recensione.AddAspettoValutato(new Aspetto("realismo", "descrizione4"), 6);
            v3.Recensione.AddAspettoValutato(new Aspetto("giocabilità", "descrizione2"), 7);

            v4.Recensione.AddAspettoValutato(new Aspetto("grafica", "descrizione1"), 3);
            v4.Recensione.AddAspettoValutato(new Aspetto("storia", "descrizione3"), 10);
            v4.Recensione.AddAspettoValutato(new Aspetto("rigiocabilità", "descrizione5"), 2);

            v8.Recensione = new Recensione("TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO  TESTO", r1);
            v8.Recensione.AddAspettoValutato(new Aspetto("grafica", "descrizione1"), 5);
            v8.Recensione.AddAspettoValutato(new Aspetto("giocabilità", "descrizione2"), 10);
            v8.Recensione.AddAspettoValutato(new Aspetto("storia", "descrizione3"), 3);

            //aggiungo preferenze agli utenti/recensori
            u1.AddPreferenza(new Aspetto("grafica", "descrizione1"), 2);
            u1.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 4);
            u1.AddPreferenza(new Aspetto("storia", "descrizione3"), 2);
            u1.AddPreferenza(new Aspetto("realismo", "descrizione4"), 6);

            u2.AddPreferenza(new Aspetto("grafica", "descrizione1"), 2);
            u2.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 1);
            u2.AddPreferenza(new Aspetto("realismo", "descrizione4"), 7);
            u2.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 2);

            u3.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 4);
            u3.AddPreferenza(new Aspetto("storia", "descrizione3"), 1);
            u3.AddPreferenza(new Aspetto("realismo", "descrizione4"), 2);
            u3.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 5);

            u4.AddPreferenza(new Aspetto("grafica", "descrizione1"), 10);
            u4.AddPreferenza(new Aspetto("storia", "descrizione3"), 3);
            u4.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 0);

            r1.AddPreferenza(new Aspetto("grafica", "descrizione1"), 8);
            r1.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 4);
            r1.AddPreferenza(new Aspetto("storia", "descrizione3"), 1);
            r1.AddPreferenza(new Aspetto("realismo", "descrizione4"), 2);
            r1.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 5);

            r2.AddPreferenza(new Aspetto("grafica", "descrizione1"), 8);
            r2.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 4);
            r2.AddPreferenza(new Aspetto("storia", "descrizione3"), 7);
            r2.AddPreferenza(new Aspetto("realismo", "descrizione4"), 2);
            r2.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 5);

            r3.AddPreferenza(new Aspetto("grafica", "descrizione1"), 7);
            r3.AddPreferenza(new Aspetto("giocabilità", "descrizione2"), 4);
            r3.AddPreferenza(new Aspetto("storia", "descrizione3"), 1);
            r3.AddPreferenza(new Aspetto("realismo", "descrizione4"), 2);
            r3.AddPreferenza(new Aspetto("rigiocabilità", "descrizione5"), 5);

            HashSet<UtenteRegistrato> utenti = new HashSet<UtenteRegistrato>();
            utenti.Add(u1);
            utenti.Add(u2);
            utenti.Add(u3);
            utenti.Add(u4);
            utenti.Add(r1);
            utenti.Add(r2);
            utenti.Add(r3);

            this._autenticatore = new Autenticatore(utenti);

            this._videogiochi = new Videogiochi();
            _videogiochi.AddVideogioco(v1);
            _videogiochi.AddVideogioco(v2);
            _videogiochi.AddVideogioco(v3);
            _videogiochi.AddVideogioco(v4);
            _videogiochi.AddVideogioco(v5);
            _videogiochi.AddVideogioco(v6);
            _videogiochi.AddVideogioco(v7);
            _videogiochi.AddVideogioco(v8);
        }

        public Videogiochi GetVideogiochi()
        {
            return this._videogiochi;
        }

        public IAutenticatore GetIAutenticatore()
        {
            return this._autenticatore;
        }
    }

}
