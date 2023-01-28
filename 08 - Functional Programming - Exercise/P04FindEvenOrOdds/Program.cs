using System;
using System.Collections.Generic;
using System.Linq;

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> numsInRange = new List<int>();
for (int i = range[0]; i <= range[1]; i++)
{
    numsInRange.Add(i);
}

string filterType = Console.ReadLine();

Predicate<int> filter = GetFilterType(filterType);

int[] filteredNums = numsInRange
    .Where(n => filter(n))
    .ToArray();
Console.WriteLine(string.Join(" ", filteredNums));
Predicate<int> GetFilterType(string filterType)
{
    if (filterType == "odd")
    {
        return n => n % 2 != 0;
    }
    else
    {
        return n => n % 2 == 0;
    }
}