using System;
using System.Collections.Generic;

string input = Console.ReadLine();
SortedDictionary<char,int> charOccurrences = new SortedDictionary<char,int>();

foreach (var ch in input)
{
	if (!charOccurrences.ContainsKey(ch))
	{
		charOccurrences.Add(ch, 0);
	}
	charOccurrences[ch]++;
}

foreach (var symbol in charOccurrences)
{
	Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}