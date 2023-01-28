using System;
using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n))
    .ToArray();

Func<int[],int> findMin = numbers =>
{
    int minNumber = int.MaxValue;
    foreach (var num in numbers)
    {
        if (num < minNumber)
        {
            minNumber = num;
        }
    }
    return minNumber;
};

Console.WriteLine(findMin(numbers));