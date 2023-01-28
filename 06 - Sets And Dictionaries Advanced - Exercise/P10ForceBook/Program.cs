using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, SortedSet<string>> forceBook = new Dictionary<string, SortedSet<string>>();

string input;
while ((input = Console.ReadLine()) != "Lumpawaroo")
{
    if (input.Contains("|"))
    {
        string[] sideUser = input
        .Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        string username = sideUser[1];
        string side = sideUser[0];

        if (!forceBook.Values.Any(u => u.Contains(username)))
        {
            if (!forceBook.ContainsKey(side))
            {
                forceBook.Add(side, new SortedSet<string>());
            }
            forceBook[side].Add(username);
        }
    }
    else if (input.Contains("->"))
    {
        string[] sideUser = input
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string username = sideUser[0];
        string side = sideUser[1];

        foreach (var sides in forceBook)
        {
            if (sides.Value.Contains(username))
            {
                forceBook[sides.Key].Remove(username);
                break;
            }
        }
        if (!forceBook.ContainsKey(side))
        {
            forceBook.Add(side, new SortedSet<string>());
        }


        forceBook[side].Add(username);
        Console.WriteLine($"{username} joins the {side} side!");
    }
}
forceBook = forceBook
    .OrderByDescending(u => u.Value.Count)
    .ThenBy(u => u.Key)
    .ToDictionary(u => u.Key, u => u.Value);

foreach (var side in forceBook)
{
    if (side.Value.Count > 0)
    {

        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
        foreach (var user in side.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}