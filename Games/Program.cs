using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            double funds = double.Parse(Console.ReadLine());

            while (funds != 0) 
            {
                var games = Console.ReadLine();
                if (games == "OutFall 4" || games == "RoverWatch Origins Edition")
                {
                    funds = funds - 39.99;
                    Console.WriteLine($"Bought {games}");
                }
                else if (games == "CS:OG")
                {
                    funds = funds - 15.99;
                    Console.WriteLine($"Bought {games}");
                }
                else if (games == "Zpliner Zell")
                {
                    funds = funds - 19.99;
                    Console.WriteLine($"Bought {games}");
                }
                else if (games == "Honored 2")
                {
                    funds = funds - 59.99;
                    Console.WriteLine($"Bought {games}");
                }
                else if (games == "RoverWatch")
                {
                    funds = funds - 29.99;
                    Console.WriteLine($"Bought {games}");
                }
            } 
            Console.WriteLine();
        }
    }
}
