using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spliting_V2._0

{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            int[] nums = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            //int[] nums = items.Select(int.Parse).ToArray();

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];                
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
