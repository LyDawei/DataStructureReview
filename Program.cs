using System;

namespace DataStructureReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing my Stack.");

            var stack = new Stack<int>();
            Console.WriteLine($"Stack Capacity: {stack.Capacity}");

            Console.WriteLine("Pushing values: 1 2 3 4 5 6 7 8 9 10");
            for (var i = 1; i <= 10; i++)
            {
                stack.Push(i);
            }


            Console.WriteLine("Pushing new value over capacity...");
            stack.Push(11);

            Console.WriteLine($"New Capacity: {stack.Capacity}");
            Console.WriteLine(stack.ToString());

        }
    }
}
