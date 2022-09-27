using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge04
{
    class Target
    {
        public static void SumArray()
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 2, 4, 5, 7, 11, 15 };
            int target = 9;
            int lenght = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"index {i} and {j} is equal to {target}");
                    }
                }
            }
        }
    }
}
