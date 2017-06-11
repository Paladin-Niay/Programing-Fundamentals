using System;

namespace Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var water = 0.70;
            var coffee = 1.00;
            var beer = 1.70;
            var tea = 1.20;

            if (proffesion == "Athlete")
            {
                Console.WriteLine($"The {proffesion} has to pay {water * quantity:f2}.");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine($"The {proffesion} has to pay {coffee * quantity:f2}.");
            }
            else if (proffesion == "SoftUni Student")
            {
                Console.WriteLine($"The {proffesion} has to pay {beer * quantity:f2}.");
            }
            else
            {
                Console.WriteLine($"The {proffesion} has to pay {tea * quantity:f2}.");
            }
        }
    }
}
