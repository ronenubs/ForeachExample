using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 45, 5, 7, 32, 64, 4 };

            //for(int index = 0; index < nums.Length; index++)
            //{
            //    Console.Write(" {0}", nums[index]);
            //}

            DisplayNumbers(a);

            Console.ReadLine();
        }

        private static void DisplayNumbers(int[] nums)
        {
            foreach (int temp in nums)
            {
                Console.Write(" {0}", temp);
            }
        }
    }
}
