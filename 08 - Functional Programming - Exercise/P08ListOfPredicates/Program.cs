using System;
using System.Collections.Generic;
using System.Linq;

int rangeEnd = int.Parse(Console.ReadLine());

List<int> numbers= new List<int>();
for (int i = 1; i <= rangeEnd; i++)
{
    numbers.Add(i);
}

HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

List<Predicate<int>> predicates = new List<Predicate<int>>();
foreach (var divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}
;
Action<List<int>> print = numbers =>
{
    foreach (var number in numbers)
    {
        bool divisible = true;
        foreach (var predicate in predicates)
        {
            if (!predicate(number))
            {
                divisible = false;
            }
        }
        if (divisible)
        {
            Console.Write(number + " ");
        }
    }
};
print(numbers);