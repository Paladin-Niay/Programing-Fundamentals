using System;


namespace Restoraunt_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = int.Parse(Console.ReadLine());
            var service = Console.ReadLine();
            double discount = 0;
            double totalPrice = 0;

            if (guests >= 1 && guests <= 50)
            {
                if (service == "Normal")
                {                    
                    discount = (2500 + 500) * 0.05;
                    totalPrice = ((2500 + 500) - discount) / guests;
                }
                else if (service == "Gold")
                {
                    discount = (2500 + 750) * 0.1;
                    totalPrice = ((2500 + 750) - discount) / guests;
                }
                else if (service == "Platinum")
                {
                    discount = (2500 + 1000) * 0.15;
                    totalPrice = ((2500 + 1000) - discount) / guests;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");
            }
            else if (guests > 50 && guests <= 100)
            {
                if (service == "Normal")
                {
                    discount = (5000 + 500) * 0.05;
                    totalPrice = ((5000 + 500) - discount) / guests;
                }
                if (service == "Gold")
                {
                    discount = (5000 + 750) * 0.5;
                    totalPrice = ((5000 + 750) - discount) / guests;
                }
                if (service == "Platinum")
                {
                    discount = (5000 + 1000) * 0.15;
                    totalPrice = ((5000 + 1000) - discount) / guests;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");
            }
            else if (guests > 100 && guests <= 120)
            {
                if (service == "Normal")
                {
                    discount = (7500 + 500) * 0.05;
                    totalPrice = ((7500 + 500) - discount) / guests;
                }
                if (service == "Gold")
                {
                    discount = (7500 + 750) * 0.1;
                    totalPrice = ((7500 + 750) - discount) / guests;
                }
                if (service == "Platinum")
                {
                    discount = (7500 + 1000) * 0.15;
                    totalPrice = ((7500 + 1000) - discount) / guests;
                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {totalPrice:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
