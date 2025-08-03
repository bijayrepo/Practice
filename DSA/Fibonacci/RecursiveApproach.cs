using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Fibonacci
{
    internal class RecursiveApproach
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
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
        //Drawbacks: Very slow for large number because of repeated calculations (exponential time complexity).
    }
}
