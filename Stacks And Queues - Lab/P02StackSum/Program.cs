using System;
using System.Collections.Generic;
using System.Linq;

namespace P02StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] commArgs = input
                    .Split();

                if (commArgs[0] == "add")
                {
                    stack.Push(int.Parse(commArgs[1]));
                    stack.Push(int.Parse(commArgs[2]));
                }
                else if (commArgs[0] == "remove")
                {
                    int n = int.Parse(commArgs[1]);
                    if (n > stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
