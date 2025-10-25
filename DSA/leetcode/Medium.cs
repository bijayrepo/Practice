using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode
{
    internal class Medium : ILeadcode
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[] merged = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    merged[k++] = nums1[i++];
                }
                else
                {
                    merged[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                merged[k++] = nums1[i++];
            }
            while (j < n)
            {
                merged[k++] = nums2[j++];
            }
            if ((m + n) % 2 == 0)
            {
                return (merged[(m + n) / 2 - 1] + merged[(m + n) / 2]) / 2.0;
            }
            else
            {
                return merged[(m + n) / 2];
            }
        }
        public string longestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int start = 0, maxLen = 1;
            for (int i = 0; i < s.Length; i++)
            {
                // Odd-length
                int left = i, right = i;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > maxLen)
                    {
                        start = left;
                        maxLen = right - left + 1;
                    }
                    left--; right++;
                }

                // Even-length
                left = i; right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > maxLen)
                    {
                        start = left;
                        maxLen = right - left + 1;
                    }
                    left--; right++;
                }
            }

            return s.Substring(start, maxLen);
        }
     
    }
    public static class RunMedium
    {
        public static void Run()
        {
            Medium medium = new Medium();
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            double result = medium.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine("Median of the two sorted arrays is: " + result);
            string longestPalindrome= medium.longestPalindrome("babad");
            Console.WriteLine("Longest Palindromic Substring is: " + longestPalindrome);
        }
    }
}
