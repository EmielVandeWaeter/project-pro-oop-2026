namespace project_pro_oop_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een woord of zin in");
            Console.ReadLine();
        }
    }
    interface IScrabble
    {
        string Input { get; set; }
        public int Aantalcharacters { get; set; }
        public int Waarde { get; set; }
    }
    class Scrabble : IScrabble
    {
        public string Input { get; set; } = "";
        public int Aantalcharacters { get; set; } = 0;
        public int Waarde { get; set; } = 0;
    }
}
