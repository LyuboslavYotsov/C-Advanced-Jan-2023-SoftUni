using System;
using System.Collections.Generic;
using System.Linq;

List<string> guestList = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = string.Empty;
while ((input = Console.ReadLine()) != "Party!")
{
    string[] commArgs = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commArgs[0];
    string filterBy = commArgs[1];
    string value = commArgs[2];

    Predicate<string> filter = GetFilterType(filterBy, value);

    if (command == "Remove")
    {
        guestList.RemoveAll(filter);
    }
    else
    {
        List<string> guestsToDouble = guestList
            .Where(guest => filter(guest))
            .ToList();

        foreach (var guestToAdd in guestsToDouble)
        {
            int index = guestList.IndexOf(guestToAdd);
            guestList.Insert(index, guestToAdd);
        }
    }
}

if (guestList.Any())
{
    Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

Predicate<string> GetFilterType(string filterBy, string value)
{
    if (filterBy == "StartsWith")
    {
        return name => name.StartsWith(value);
    }
    else if (filterBy == "EndsWith")
    {
        return name => name.EndsWith(value);
    }
    return name => name.Length == int.Parse(value);
}