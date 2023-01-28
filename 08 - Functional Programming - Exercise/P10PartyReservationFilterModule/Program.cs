using System;
using System.Collections.Generic;
using System.Linq;

List<string> guestList = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = string.Empty;
Dictionary<string, Predicate<string>> filtersToApply = new Dictionary<string, Predicate<string>>();
while ((input = Console.ReadLine()) != "Print")
{
    string[] commArgs = input
        .Split(";", StringSplitOptions.RemoveEmptyEntries);
    string command = commArgs[0];
    string filterType = commArgs[1];
    string value = commArgs[2];

    Predicate<string> currFilter = GetFilterType(filterType, value);

    if (command == "Add filter")
    {
        filtersToApply.Add(filterType + value, currFilter);
    }
    else
    {
        filtersToApply.Remove(filterType + value);
    }
}

foreach (var filter in filtersToApply)
{
    var thisFilter = filter.Value;
    guestList = guestList
        .Where(g => !thisFilter(g))
        .ToList();
        
}

Console.WriteLine(string.Join(" ", guestList));


Predicate<string> GetFilterType(string filterBy, string value)
{
    if (filterBy == "Starts with")
    {
        return name => name.StartsWith(value);
    }
    else if (filterBy == "Ends with")
    {
        return name => name.EndsWith(value);
    }
    else if (filterBy == "Contains")
    {
        return name => name.Contains(value);
    }
    return name => name.Length == int.Parse(value);
}