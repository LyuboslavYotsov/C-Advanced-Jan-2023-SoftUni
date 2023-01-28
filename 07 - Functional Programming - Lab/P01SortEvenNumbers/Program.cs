using System;
using System.Linq;


Func<string, int> parser = number => int.Parse(number);

int[] numbers = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(parser)
    .ToArray();

numbers = numbers
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToArray();

Console.WriteLine(string.Join(", ",numbers));