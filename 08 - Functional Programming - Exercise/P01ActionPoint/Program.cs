using System;

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printNames = names =>
{
	foreach (var name in names)
	{
		Console.WriteLine(name);
	}
};

printNames(names);