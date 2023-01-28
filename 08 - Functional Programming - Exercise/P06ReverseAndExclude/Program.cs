using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();


int divider = int.Parse(Console.ReadLine());

Predicate<int> filter = n => n % divider != 0;

numbers = numbers
    .Where(n => filter(n))
    .Reverse()
    .ToList();


Console.WriteLine(string.Join(" ", numbers));