using System;

namespace DataStructureReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing BubbleSort");
            Console.WriteLine("==================");

            var arr = new int[10];
            var rand = new Random();

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 50;
            }

            arr.Entries();

            Console.WriteLine();


            arr.BubbleSort();

            arr.Entries();



            Console.WriteLine("Testing MergeSort");
            Console.WriteLine("==================");

            var arr2 = new int[25];

            for (var i = 0; i < 25; i++)
            {
                arr2[i] = rand.Next() % 60 + 1;
            }

            arr2.Entries();

            Console.WriteLine();

            arr2 = arr2.MergeSort();

            arr2.Entries();
        }
    }
}
