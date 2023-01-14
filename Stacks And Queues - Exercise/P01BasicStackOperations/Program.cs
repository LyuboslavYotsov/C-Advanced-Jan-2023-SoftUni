using System;
using System.Collections.Generic;
using System.Linq;

namespace P01BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int elementsCount = keyNumbers[0];
            int popCount = keyNumbers[1];
            int targetNum = keyNumbers[2];
            Stack<int> stack = new Stack<int>();
            
            bool targetFound = false;

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < elementsCount; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(targetNum))
            {
                targetFound = true;
            }

            if (stack.Count > 0)
            {
                if (targetFound)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
