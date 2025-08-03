namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci.RecursiveApproach.Run();
            Fibonacci.IteractiveApproach.Run();
            Fibonacci.DynamicProgramming.Run();
            Fibonacci.UningLINQ.Run();
            Console.WriteLine();
        }
    }
}
