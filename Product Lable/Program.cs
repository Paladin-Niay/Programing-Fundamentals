using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Lable
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyPer100ml = double.Parse(Console.ReadLine());
            var sugarPer100ml = double.Parse(Console.ReadLine());

            var energyTotal = (energyPer100ml * volume) / 100;
            var sugarTotal = (sugarPer100ml * volume) / 100;

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{energyTotal}kcal, {sugarTotal:f2}g sugars");
        }
    }
}
