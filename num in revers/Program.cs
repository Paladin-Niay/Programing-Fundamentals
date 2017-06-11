using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_in_revers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            //Console.WriteLine("These are the numbers in reverse:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
