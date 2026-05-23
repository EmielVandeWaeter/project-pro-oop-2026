using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naam inlezen van de gebruiker
            Console.WriteLine("Wat is u naam?");
            string naam = Console.ReadLine();

            //De input van de gebruiker vragen
            Console.WriteLine("Geef een woord of zin in");

            //Object aanmaken voor klasse "bepalen"
            Bepalen gebruiker = new Bepalen();

            //De functie "Berekenwaarde" aanroepen + polymorfisme(naam)
            gebruiker.Berekenwaarde(naam);
        }
    }

    //abstractie: interface met Input property
    interface IScrabble
    {
        string Input { get; set; }
    }

    //Basisklasse: encapsulatie via autoproperties
    class Scrabble : IScrabble
    {
        public string Input { get; set; } = "";
        public int Aantalcharacters { get; set; } = 0;
        public int totaalWaardeKarakters { get; set; } = 0;
    }

    //Overerving: Bepalen erft van Scrabble.
    class Bepalen : Scrabble
    {
        //Constructor, deze code word uitgevoerd wanneer het object word aangemaakt.
        public Bepalen()
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
                    Aantalcharacters++;
                    //+= telt de nieuwe waarde op bij de bestaande waarde van de variabelen.
                    totaalWaardeKarakters += random.Next(0, 26);
                }
                Console.WriteLine("Aantal characters: " + Aantalcharacters);
                Console.WriteLine("Totale waarde: " + totaalWaardeKarakters);
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
                    //Elke keer door de loop is Aantalcharacters + 1
                    Aantalcharacters++;
                    //+= telt de nieuwe waarde op bij de bestaande waarde van de variabelen.
                    totaalWaardeKarakters += random.Next(0, 26);
                }
                Console.WriteLine("beste " + naam + ", in uw zin zitten " + Aantalcharacters + " characters");
                Console.WriteLine("Totale waarde: " + totaalWaardeKarakters);
            }
            catch
            {
                Console.WriteLine("Er is een fout opgetreden, probeer opnieuw.");
            }
        }

    }
}
