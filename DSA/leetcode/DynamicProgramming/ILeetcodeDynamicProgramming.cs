using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.leetcode.DynamicProgramming
{
    public interface ILeetcodeDynamicProgramming
    {
        public int ClimbStairs(int n);
        public IList<IList<int>> Generate(int numRows);
        public int MaxProfit(int[] prices);
        public int Fib(int n);
        public int[] CountBits(int n);
        public int MinCostClimbingStairs(int[] cost);
        public bool DivisorGame(int n);
        public bool IsSubsequence(string s, string t);
    }
}
