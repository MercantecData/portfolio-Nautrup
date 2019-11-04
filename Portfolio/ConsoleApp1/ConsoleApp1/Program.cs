using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ArrayCounter();
        }

        static void ArrayCounter()
        {
            Console.WriteLine("Write a number : ");
            int input = int.Parse(Console.ReadLine());
            int[] arrayCount = new int[input];
            foreach (var number in arrayCount)
            {
                Console.WriteLine(number);
            }
        }
    }
}
