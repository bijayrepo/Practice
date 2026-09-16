using DSA.Arrays.Array_Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Arrays.Array_service
{
    public class Array_Service: Array_interface
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            List<int> disappeared = new List<int>();

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!numSet.Contains(i))
                {
                    disappeared.Add(i);
                }
            }

            return disappeared;
        }
    }
}
