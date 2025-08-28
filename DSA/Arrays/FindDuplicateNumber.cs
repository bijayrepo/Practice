using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class FindDuplicateNumber
    {
        internal static void Run()
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            int duplicate = FindDuplicate(nums);
            Console.WriteLine($"The duplicate number is: {duplicate}");
        }
        public static int FindDuplicate(int[] nums)
        {
            int duplicate = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                {
                    duplicate = Math.Abs(nums[i]);
                    break;
                }
                nums[index] = -nums[index];
            }

            return duplicate;
        }
    }
}
