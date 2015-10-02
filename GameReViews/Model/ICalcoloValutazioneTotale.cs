using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameReViews.Model
{
    public interface ICalcoloValutazioneTotale
    {
         float Calcola(Recensione recensione);
    }

    //statica
    static class CalcoloValutazioneTotaleFactory
    {
        public static ICalcoloValutazioneTotale GetCalcoloValutazioneTotale()
        {
            //default, media non ponderata
            return new CalcoloValutazioneNonPersonalizzata();
        }

        public static ICalcoloValutazioneTotale GetCalcoloValutazioneTotale(UtenteRegistrato utente)
        {
            //Media ponderata
            return new CalcoloValutazionePersonalizzata(utente);
        }
    }

    //media pesata in base al match delle stringhe dei nomi degli aspetti tra recensione e utente
    class CalcoloValutazionePersonalizzata : ICalcoloValutazioneTotale
    {
        private UtenteRegistrato _utente;

        public CalcoloValutazionePersonalizzata(UtenteRegistrato utente)
        {
            #region Precondizioni
            if (utente == null||utente.Preferenze==null)
                throw new ArgumentNullException("utente==null||utente.GetPreferenze()==null");
            #endregion

            this._utente = utente;
        }

        //poichè questo metodo necessita anche dell'utente (o del delegato, vedi sopra), esso è fornito nel costruttore
        public float Calcola(Recensione recensione)
        {
            #region Precondizioni
            if (recensione == null || recensione.AspettiValutati== null)
                throw new ArgumentNullException("recensione==null||recensione.GetAspettiValutati()==null");
            #endregion

            //somma parziale per la media ponderata
            int sum=0;
            //denominatore della media ponderata
            int sumPreferenze=0;
            //conteggio dei match
            int count=0;

            foreach(AspettoValore aspettoValutato in recensione.AspettiValutati)
            {
                foreach(AspettoValore preferenza in _utente.Preferenze)
                {
                    // == per le stringhe è uguaglianza dei valori
                    if(aspettoValutato.Aspetto.Nome==preferenza.Aspetto.Nome)
                    {
                        //aggiorno le sommatorie
                        sum += aspettoValutato.Valore * preferenza.Valore;
                        sumPreferenze += preferenza.Valore;
                        count+=1;

                        //interrompo il for interno per efficienza
                        break;
                    }
                }
            }

            //ritorno NaN se non c'è stato neanche un match oppure se al denominatore ho 0
            if (count == 0 || sumPreferenze==0)
                return float.NaN;

            //i cast forzano la divisione tra reali e non tra interi
            return (float) sum / (float) sumPreferenze;
        }
    }

    class CalcoloValutazioneNonPersonalizzata : ICalcoloValutazioneTotale
    {
        //semplicemente la media
        public float Calcola(Recensione recensione)
        {
            #region Precondizioni
            if (recensione == null || recensione.AspettiValutati==null)
                throw new ArgumentNullException("recensione==null||recensione.GetAspettiValutati()==null");
            #endregion

            //recupero solo le valutazioni
            IEnumerable<int> valutazioni = from aspettoValutato in recensione.AspettiValutati select aspettoValutato.Valore;

            //ritorno NaN se non ci sono valutazioni (O ECCEZIONE!?!?)
            if (valutazioni.Count() == 0)
                return float.NaN;

            //c'è già una funzione apposta per la media
            return (float) valutazioni.Average();
        }
    }
}
