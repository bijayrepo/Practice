using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Fibonacci
{
    internal class DynamicProgramming
    {
        static Dictionary<int, int> memo = new Dictionary<int, int>();
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            if (memo.ContainsKey(n))
                return memo[n];
            memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            return memo[n];
        }
       public static void Run()
        {
            Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci sequence:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        //Advantages: Much faster than recursive approach (linear time complexity).
    }
}
