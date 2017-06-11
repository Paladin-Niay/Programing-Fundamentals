using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var HP = int.Parse(Console.ReadLine());
            var maxHP = int.Parse(Console.ReadLine());
            var MP = int.Parse(Console.ReadLine());
            var maxMP = int.Parse(Console.ReadLine());

            string colHP = new string('|', HP);
            string dotHP = new string('.', maxHP - HP);
            string colMP = new string('|', MP);
            string dotMP = new string('.', maxMP - MP);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: " + "|" + colHP + dotHP + "|");
            Console.WriteLine("Energy: " + "|" + colMP + dotMP + "|");
        }
    }
}
