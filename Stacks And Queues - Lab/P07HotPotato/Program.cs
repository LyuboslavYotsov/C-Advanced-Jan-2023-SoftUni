using System;
using System.Collections.Generic;

namespace P07HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine()
                .Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);
            int tosses = 1;

            while (queue.Count > 1)
            {
                string kidName = queue.Dequeue();
                if (tosses != n )
                {
                    queue.Enqueue(kidName);
                    tosses++;
                }
                else
                {
                    tosses = 1;
                    Console.WriteLine($"Removed {kidName}");
                }
                
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
