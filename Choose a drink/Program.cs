﻿using System;

namespace Choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine().ToLower();
            
            if (proffesion == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (proffesion == "businessman" || proffesion == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
