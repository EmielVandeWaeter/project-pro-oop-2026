using System;

namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is u naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef een woord of zin in");
            Bepalen gebruiker = new Bepalen();
            gebruiker.Berekenwaarde();
        }
    }
    interface IScrabble
    {
        string Input { get; set; }
    }
    class Scrabble : IScrabble
    {
        public string Input { get; set; } = "";
        public int Aantalcharacters { get; set; } = 0;
        public int totaalWaardeKarakters { get; set; } = 0;
    }
    class Bepalen : Scrabble
    { 
        public Bepalen()
        {
            Input = Console.ReadLine();
        }
        public void Berekenwaarde()
        {
            Random random = new Random();
            try 
            {
                foreach (char c in Input) 
                {
                    Aantalcharacters++;
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
        public void Berekenwaarde(string naam) 
        {
            Random random = new Random();
            try
            {
                foreach (char c in Input)
                {
                    Aantalcharacters++;
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
