using System;


namespace Ractangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", (w * l));
        }
    }
}
