using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode.Algorithms
{
    internal class Algorithims_leedcode:IAlgorithms_leedcode
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int original = x;
            int reversed = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            return original == reversed;
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 2];
                }
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2];
                        if (p[j - 2] == s[i - 1] || p[j - 2] == '.')
                        {
                            dp[i, j] |= dp[i - 1, j];
                        }
                    }
                }
            }
            return dp[m, n];
        }
    }
}
