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
        public int Waarde { get; set; } = 0;
    }
    class Bepalen : Scrabble
    { 
        public Bepalen()
        {
            Input = Console.ReadLine();
        }
        public void Berekenwaarde()
        {
            try 
            {
                foreach (char c in Input) 
                {
                    Aantalcharacters++;
                }
                Console.WriteLine("Aantal characters: " + Aantalcharacters);
            }
            catch 
            {
                Console.WriteLine("Er is een fout opgetreden, probeer opnieuw.");
            }

        }
        public void Berekenwaarde(string naam) 
        {
            try
            {
                foreach (char c in Input)
                {
                    Aantalcharacters++;
                }
                Console.WriteLine("beste " + naam + ", in uw zin zitten " + Aantalcharacters + " characters");
            }
            catch
            {
                Console.WriteLine("Er is een fout opgetreden, probeer opnieuw.");
            }
        }

    }
}
