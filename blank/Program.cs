using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blank
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = { "one", "two", "three", "four", "five" };
            //Console.WriteLine(String.Join(", ", arr));
            //Console.WriteLine(String.Join("\r\n", arr));

            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //
            //int[] reversed = new int[nums.Length];
            //
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    reversed[i] = nums[nums.Length - i - 1];
            //}
            //Console.WriteLine(String.Join(" ", reversed));

            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double[] nums = ReadNumbers();
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int) Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");
            }
        }

        private static double[] ReadNumbers()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            return nums;
        }
    }
}
