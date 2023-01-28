using System;
using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] sorted = numbers
    .OrderByDescending(x => x)
    .ToArray();

Console.WriteLine(string.Join(" ",sorted.Take(3)));