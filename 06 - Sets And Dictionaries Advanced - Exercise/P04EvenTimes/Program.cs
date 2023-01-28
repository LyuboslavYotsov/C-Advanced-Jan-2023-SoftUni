using System;
using System.Collections.Generic;
using System.Linq;

int count = int.Parse(Console.ReadLine());
Dictionary<int,int> numbers = new Dictionary<int,int>();

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

	if (!numbers.ContainsKey(number))
	{
		numbers.Add(number, 0);
	}
	numbers[number]++;
}

numbers = numbers
	.OrderByDescending(n => n.Value)
	.Where(n => n.Value % 2 == 0)
	.Take(1)
	.ToDictionary(x => x.Key, x => x.Value);

foreach (var number in numbers)
{
	Console.WriteLine(number.Key);
}