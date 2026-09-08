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
        public int[] plusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {

                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Pointer for nums1
            int j = n - 1; // Pointer for nums2
            int k = m + n - 1; // Pointer for the merged array
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            // If there are remaining elements in nums2, copy them to nums1
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
