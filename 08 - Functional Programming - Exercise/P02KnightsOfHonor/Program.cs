using System;

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printNamesWithTitle = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine("Sir " + name);
    }
};

printNamesWithTitle(names);