using System;
using System.Collections.Generic;

int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> continentsWithCountries = new Dictionary<string, Dictionary<string, List<string>>>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!continentsWithCountries.ContainsKey(continent))
    {
        continentsWithCountries[continent] = new Dictionary<string, List<string>>();
    }
    if (!continentsWithCountries[continent].ContainsKey(country))
    {
        continentsWithCountries[continent][country] = new List<string>();
    }
    continentsWithCountries[continent][country].Add(city);
}

foreach (var continent in continentsWithCountries)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
    }
}