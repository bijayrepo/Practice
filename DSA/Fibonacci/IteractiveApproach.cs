using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Fibonacci
{
    internal class IteractiveApproach
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
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
        //Efficient: O(n) time, O(1) space
    }
}
