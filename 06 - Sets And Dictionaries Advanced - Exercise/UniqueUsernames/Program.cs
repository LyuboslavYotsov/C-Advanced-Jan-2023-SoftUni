using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
HashSet<string> names = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
	if (!names.Contains(name))
	{
		names.Add(name);
		Console.WriteLine(name);
	}
}