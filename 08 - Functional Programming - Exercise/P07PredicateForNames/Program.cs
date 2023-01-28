using System;
using System.Collections.Generic;
using System.Linq;

int lenghtFilter = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


Predicate<string> filterByLenght = name =>
{
    if (name.Length <= lenghtFilter)
    {
        return true;
    }
    return false;
};

names = names
    .Where(name => filterByLenght(name))
    .ToList();

foreach (var name in names)
{
    Console.WriteLine(name);
}