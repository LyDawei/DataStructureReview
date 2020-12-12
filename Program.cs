using System;

namespace DataStructureReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing LinkedList");

            var list = new LinkedList<int>();

            for (var i = 0; i < 10; i++)
            {
                list.PushBack(i + 1);
            }


            Console.WriteLine(list.ToString());

            list.Remove(5);

            Console.WriteLine(list.ToString());


        }
    }
}
