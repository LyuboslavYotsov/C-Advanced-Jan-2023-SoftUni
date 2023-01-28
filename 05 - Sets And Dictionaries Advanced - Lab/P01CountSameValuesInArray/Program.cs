using System;
using System.Collections.Generic;

string[] input = Console.ReadLine()
    .Split(' ');

Dictionary<string,int> dictionary = new Dictionary<string,int>();

foreach (var number in input)
{
	if (!dictionary.ContainsKey(number))
	{
		dictionary[number] = 0;
		dictionary[number]++;
	}
	else
	{
        dictionary[number]++;
    }
}
foreach (var kvp in dictionary)
{
	Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
}