using System;
using System.Collections.Generic;
using System.Text;

int operationsCount = int.Parse(Console.ReadLine());
StringBuilder text= new StringBuilder();
text.Append("");
Stack<string> lastChange = new Stack<string>();
lastChange.Push(text.ToString());

for (int i = 0; i < operationsCount; i++)
{
    string[] commArgs = Console.ReadLine()
        .Split(' ',StringSplitOptions.RemoveEmptyEntries);

    string command = commArgs[0];

    if (command == "1")
    {
        string value = commArgs[1];
        lastChange.Push(text.ToString());
        text.Append(value);
    }

    else if (command == "2")
    {
        int count = int.Parse(commArgs[1]);
        int startIndex = text.ToString().Length - count;
        lastChange.Push(text.ToString());
        text.Remove(startIndex,count);
    }
    else if (command == "3")
    {
        int index = int.Parse(commArgs[1]);
        if (index >= 0 && index <= text.ToString().Length)
        {
            char currCh = text.ToString()[index - 1];
            Console.WriteLine(currCh);
        }
    }
    else if (command == "4")
    {
        text.Clear();
        text.Append(lastChange.Pop());
    }
}