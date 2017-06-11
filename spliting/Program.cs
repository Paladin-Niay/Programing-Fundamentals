using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spliting
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            int[] nums = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
                nums[i] = int.Parse(items[i]);

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.WriteLine("Sum = " + sum);
            }            
        }
    }
}
