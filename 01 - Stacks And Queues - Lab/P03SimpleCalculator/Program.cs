using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine()
                .Split();

            Stack<string> stack = new Stack<string>(expression.Reverse());
            int sum = int.Parse(stack.Pop());

            while (stack.Count > 1)
            {
                char operatoion = char.Parse(stack.Pop());
                int number = int.Parse(stack.Pop());

                if (operatoion == '+')
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
