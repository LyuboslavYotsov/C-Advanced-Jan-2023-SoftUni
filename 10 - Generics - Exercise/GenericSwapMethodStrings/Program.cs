using GenericSwapMethodStrings;
using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Box<string> stringBox = new Box<string>();
for (int i = 0; i < n; i++)
{
    string value = Console.ReadLine();
    stringBox.Add(value);
}

int[] indexes = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

stringBox.SwapElements(indexes[0], indexes[1]);

Console.WriteLine(stringBox.ToString());