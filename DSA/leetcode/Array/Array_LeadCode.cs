using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode.Array
{
    public class Array_LeadCode : IArray_LeadCode
    {
        public int removeDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            if (nums.Length > 0)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] != val)
                    {
                        nums[i] = nums[j];
                        i++;
                    }
                }

            }
            return i;
        }

        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length > 0)
            {
                int left = 0;
                int right = nums.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                return left; // Return the index where the target should be inserted

            }
            else
            {
                return 0;
            }
        }
    }
}
