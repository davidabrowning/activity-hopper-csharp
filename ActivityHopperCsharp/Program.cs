namespace ActivityHopperCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                ShowMenu();
                switch (Console.ReadLine().ToUpper())
                {
                    case "Q":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Go for a walk");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[ENTER] Choose a random activity");
            Console.WriteLine("[Q] Quit");
        }
    }
}
