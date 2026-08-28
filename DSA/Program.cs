using DSA.Arrays;
using DSA.leetcode;
using DSA.leetcode.DynamicProgramming;
using DSA.LINQ;
using DSA.List;
using Microsoft.Extensions.DependencyInjection;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.DynamicProgrammingAddApplicationServices();
            var serviceProvider = services.BuildServiceProvider();
            //Fibonacci Series
            //Fibonacci.RecursiveApproach.Run();
            //Fibonacci.IteractiveApproach.Run();
            //Fibonacci.DynamicProgramming.Run();
            //Fibonacci.UningLINQ.Run();
            //Fibonacci Series End
            //Arrays
            //TraverseArrays.Traverse();
            //LinearSearch.Linear(5);
            //ReversingList.Run();
            //LinqQuery.Linq();
            //TimeComplexity
            //TimeComplexity.RunTimeComplexityMedium.Run();
            //InterviewQuestions
            //Interview.InterviewQuestions.Run();
            //Leetcode
            //RunMedium.Run();
            //Console.WriteLine();
            //Dynamic Programming
            //ILeetcodeDynamicProgramming leetcodeDynamicProgramming = new LeetcodeDynamicPrograming();
           
            var dynamicProgramming = serviceProvider.GetRequiredService<ILeetcodeDynamicProgramming>();
            Console.WriteLine(dynamicProgramming.ClimbStairs(5));
            Console.WriteLine(string.Join(", ", dynamicProgramming.Generate(3).Select(row => string.Join(", ", row))));
            Console.WriteLine("Stock maximum profit: " + dynamicProgramming.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(dynamicProgramming.Fib(3));
            //DynamicProgramming End
        }
    }
}
