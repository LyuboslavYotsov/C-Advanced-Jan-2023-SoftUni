using System;
using System.Linq;

int targetSum = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, int, bool> match = (string name, int targetSum) => name.Sum(ch => ch) >= targetSum;

Func<string[], int, Func<string, int, bool>, string> getName =
    (names, targetSum, match) => names.FirstOrDefault(name => match(name, targetSum));

Console.WriteLine(getName(names,targetSum,match));

 