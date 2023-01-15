using System;
using System.Collections.Generic;

namespace P08TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passing = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passes = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < passing; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passes++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{passes} cars passed the crossroads.");
        }
    }
}
