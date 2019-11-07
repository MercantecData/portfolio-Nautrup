using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCounter();
        }

        static int ArrayCounter()
        {
            Console.Write("Write a number : ");
            int input = int.Parse(Console.ReadLine());
            int[] intArray = new int[input];

            int counter = 1;
            while (counter <= intArray.Length)
            {
                Console.WriteLine(counter);
                counter += 1;
            }
            return counter;
        }
    }
}
