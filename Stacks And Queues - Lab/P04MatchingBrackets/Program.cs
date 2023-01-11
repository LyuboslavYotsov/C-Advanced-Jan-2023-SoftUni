using System;
using System.Collections.Generic;

namespace P04MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    int openingBracket = i;
                    stack.Push(openingBracket);
                }
                if (input[i] == ')')
                {
                    int lenght = i - stack.Peek() + 1;
                    string expresion = input.Substring(stack.Pop(), lenght);
                    Console.WriteLine(expresion);
                }
            }
        }
    }
}
