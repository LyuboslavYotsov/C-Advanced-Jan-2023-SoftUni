using System;
using System.Collections.Generic;

string input = Console.ReadLine();
Stack<char> parantheses = new Stack<char>();

foreach (char item in input)
{
	if (item == '(' || item == '[' || item == '{')
	{
		parantheses.Push(item);
	}
	else if (item == ')')
	{
		if (parantheses.Count == 0 || parantheses.Pop() != '(')
		{
			Console.WriteLine("NO");
			return;
		}
	}
	else if (item == '}')
	{
        if (parantheses.Count == 0 || parantheses.Pop() != '{')
        {
            Console.WriteLine("NO");
            return;
        }
    }
	else if (parantheses.Count == 0 || parantheses.Pop() == ']')
	{
        if (parantheses.Pop() != '[')
        {
            Console.WriteLine("NO");
            return;
        }
    }
}
if (parantheses.Count != 0)
{
	Console.WriteLine("NO");
}
else
{
	Console.WriteLine("YES");
}