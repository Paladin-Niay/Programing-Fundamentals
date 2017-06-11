using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("x" + new string(' ', n - 2) + "x");
                Console.WriteLine(new string(' ', ++i) + "x" + new string(' ', n - i) + "x" + new string(' ', ++i));
            }
        }
    }
}
