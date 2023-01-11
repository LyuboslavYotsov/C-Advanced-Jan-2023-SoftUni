using System;
using System.Collections.Generic;
using System.Linq;

namespace P06PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    queue.Enqueue(number);
                }
            }
            Console.WriteLine(string.Join(", ", queue.ToArray()));
        }
    }
}
