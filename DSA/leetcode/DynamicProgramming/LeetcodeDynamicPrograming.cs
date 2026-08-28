using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.leetcode.DynamicProgramming
{
    public class LeetcodeDynamicPrograming : ILeetcodeDynamicProgramming
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;
            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }
            return second;
        }
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            IList<int> rowCopy = new List<int>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                    }
                }
                rowCopy = row.ToList(); // Create a copy of the row
                triangle.Add(row);
            }
            rowCopy = triangle[triangle.Count - 1]; // Create a copy of the row
            return triangle;
        }
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int minPrice = int.MaxValue;
            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else if (price - minPrice > max)
                {
                    max = price - minPrice;
                }
            }
            return max;
        }

        public int Fib(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                ans[i] = ans[i & (i - 1)] + 1;
            }
            return ans;
        }
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost == null || cost.Length == 0) return 0;
            int n = cost.Length;
            //if (n == 1) return 0; // can start at step 1 (the top) with zero cost

            // dp[i] = cost to reach step i (0-based). We only need the last two values.
            int prev2 = 0;
            int prev1 = 0;

            for (int i = 2; i <= n; i++)
            {
                int curr = Math.Min(prev1 + cost[i-1], prev2 + cost[i-2]);
                prev2 = prev1;
                prev1 = curr;
            }

            // To reach the top (one step past the last index) we can come from last or second-last
            return prev1;
        }

        public bool DivisorGame(int n)
        {
           
            return n % 2 == 0;
        }
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            return sIndex == s.Length;
        }
    }
}
