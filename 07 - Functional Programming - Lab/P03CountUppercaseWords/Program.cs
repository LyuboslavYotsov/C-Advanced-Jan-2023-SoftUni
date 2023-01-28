using System;
using System.Linq;

Func<string,bool> filterByUpperCase = s => s[0] == char.ToUpper(s[0]) && char.IsLetter(s[0]);

string[] words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(filterByUpperCase)
    .ToArray();


Action<string[]> print = PrintArray;
print(words);

static void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}