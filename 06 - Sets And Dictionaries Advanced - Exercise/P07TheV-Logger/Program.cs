using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, Dictionary<string, HashSet<string>>> vLogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();

string input;
while ((input = Console.ReadLine()) != "Statistics")
{
    string[] commArgs = input
        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
    string command = commArgs[1];
    string vlogerName = commArgs[0];
    if (command == "joined")
    {
        if (!vLogger.ContainsKey(vlogerName))
        {
            vLogger.Add(vlogerName, new Dictionary<string, HashSet<string>>());
            vLogger[vlogerName].Add("followers", new HashSet<string>());
            vLogger[vlogerName].Add("following", new HashSet<string>());
        }

    }
    else if (command == "followed")
    {
        string followedName = commArgs[2];

        if (vLogger.ContainsKey(vlogerName) && vLogger.ContainsKey(followedName) && followedName != vlogerName)
        {
            vLogger[vlogerName]["following"].Add(followedName);
            vLogger[followedName]["followers"].Add(vlogerName);
        }
    }
}
vLogger = vLogger
    .OrderByDescending(x => x.Value["followers"].Count)
    .ThenBy(x => x.Value["following"].Count)
    .ToDictionary(x => x.Key,x => x.Value);

Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
int count = 1;

foreach (var person in vLogger)
{
    Console.WriteLine($"{count}. {person.Key} : {person.Value["followers"].Count} followers, {person.Value["following"].Count} following");
    if (count == 1)
    {
        foreach (var follower in person.Value["followers"].OrderBy(n => n))
        {
            Console.WriteLine($"*  {follower}");
        }
    }
    count++;
}

