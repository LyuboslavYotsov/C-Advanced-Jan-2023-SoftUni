using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string,int> languageSubmissions = new Dictionary<string,int>();
Dictionary<string,int> userPoints = new Dictionary<string,int>();

string input;
while((input = Console.ReadLine()) != "exam finished")
{
    string[] tokens = input
        .Split("-", StringSplitOptions.RemoveEmptyEntries);

    string username = tokens[0];
    string language = tokens[1];
    if (language == "banned")
    {
        if (userPoints.ContainsKey(username))
        {
            userPoints.Remove(username);
        }
        continue;
    }
    int points = int.Parse(tokens[2]);

    if (!userPoints.ContainsKey(username))
    {
        userPoints.Add(username, 0);
    }
    if (!languageSubmissions.ContainsKey(language))
    {
        languageSubmissions.Add(language, 0);
    }
    if (userPoints[username] < points)
    {
        userPoints[username] = points;
    }
    languageSubmissions[language]++;
}

userPoints = userPoints
    .OrderByDescending(u => u.Value)
    .ThenBy(u => u.Key)
    .ToDictionary(x => x.Key, x => x.Value);

languageSubmissions = languageSubmissions
    .OrderByDescending(u => u.Value)
    .ThenBy(u => u.Key)
    .ToDictionary(x => x.Key, x => x.Value);

Console.WriteLine("Results:");

foreach (var user in userPoints)
{
    Console.WriteLine($"{user.Key} | {user.Value}");
}

Console.WriteLine("Submissions:");

foreach (var language in languageSubmissions)
{
    Console.WriteLine($"{language.Key} - {language.Value}");
}