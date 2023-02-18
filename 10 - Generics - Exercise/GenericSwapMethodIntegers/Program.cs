using GenericSwapMethodIntegers;
using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Box<int> stringBox = new Box<int>();
for (int i = 0; i < n; i++)
{
    int value = int.Parse(Console.ReadLine());
    stringBox.Add(value);
}

int[] indexes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

stringBox.SwapElements(indexes[0], indexes[1]);

Console.WriteLine(stringBox.ToString());