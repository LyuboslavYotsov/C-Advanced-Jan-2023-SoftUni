using System;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
    foreach (var element in input)
    {
        elements.Add(element);
    }
}
Console.WriteLine(string.Join(" ", elements));