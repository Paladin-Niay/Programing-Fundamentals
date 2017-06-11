using System;

namespace Miles_to_KM
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            var km = mile * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}
