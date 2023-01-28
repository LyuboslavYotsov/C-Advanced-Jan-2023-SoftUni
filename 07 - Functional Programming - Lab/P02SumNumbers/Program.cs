using System;
using System.Linq;

Func<string, int> parser = n => int.Parse(n);
int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(parser)
    .ToArray();

Func<int[], int> getSum = SumNumbers;
Func<int[], int> getCount = GetCount;


Console.WriteLine(getCount(numbers));
Console.WriteLine(getSum(numbers));

static int SumNumbers(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum;
}

static int GetCount(int[] numbers)
{
    int count = numbers.Length;

    return count;
}