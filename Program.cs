using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabelen declareren
            string naam = "";
            try
            {   //naam inlezen van de gebruiker
                Console.WriteLine("Wat is u naam?");
                naam = Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Geef een geldige naam in");
            }

            //De input van de gebruiker vragen
            Console.WriteLine("Geef een woord of zin in");

            //Object aanmaken voor klasse "bepalen"
            Scrabble gebruiker = new Scrabble();

            //De functie "Berekenwaarde" aanroepen + polymorfisme(naam)
            gebruiker.Berekenwaarde(naam);
        }
    }

    //abstractie: interface met methode bereken waarde (gedrag)
    interface iBereken
    {
        void Berekenwaarde();
    }

    //Basisklasse: encapsulatie via autoproperties
    class ScrabbleBase
    {
        public string Input { get; set; } = "";
        public int AantalKarakters { get; set; } = 0;
        public int TotaalWaardeKarakters { get; set; } = 0;
    }

    //Overerving: Bepalen erft van Scrabble.
    class Scrabble : ScrabbleBase, iBereken
    {
        //Constructor, deze code word uitgevoerd wanneer het object word aangemaakt.
        public Scrabble()
        {
            Input = Console.ReadLine();
        }

        //Polymorfisme versie 1, zonder naam.
        public void Berekenwaarde()
        {
            //object random aanmaken
            Random random = new Random();
            //trycatch voor fouten op te vangen
            try
            {
                foreach (char c in Input)
                {
                    //Elke keer door de loop is Aantalcharacters + 1
                    AantalKarakters++;
                    //+= telt de nieuwe waarde op bij de bestaande waarde van de variabelen.
                    TotaalWaardeKarakters += random.Next(0, 26);
                }
                Console.WriteLine("Aantal characters: " + AantalKarakters);
                Console.WriteLine("Totale waarde: " + TotaalWaardeKarakters);
            }
            catch
            {
                Console.WriteLine("Er is een fout opgetreden, probeer opnieuw.");
            }
        }
        //Polymorfisme versie 2 met naam
        public void Berekenwaarde(string naam) 
        {
            //Object random aanmaken.
            Random random = new Random();
            //Try catch voor fouten op te vangen
            try
            {
                foreach (char c in Input)
                {
                    //Elke keer door de loop is AantalKarakters + 1
                    AantalKarakters++;
                    //+= telt de nieuwe waarde op bij de bestaande waarde van de variabelen.
                    TotaalWaardeKarakters += random.Next(0, 26);
                }
                Console.WriteLine("beste " + naam + ", in uw zin zitten " + AantalKarakters + " characters");
                Console.WriteLine("Totale waarde: " + TotaalWaardeKarakters);
            }
            catch
            {
                Console.WriteLine("Er is een fout opgetreden, probeer opnieuw.");
            }
        }

    }
}