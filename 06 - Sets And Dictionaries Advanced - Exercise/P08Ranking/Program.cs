using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string,string> contestPass = new Dictionary<string,string>();
Dictionary<string, Dictionary<string, int>> userInfo = new Dictionary<string, Dictionary<string, int>>();

string contestsInput;
while ((contestsInput = Console.ReadLine()) != "end of contests")
{
    string[] tokens = contestsInput
        .Split(":",StringSplitOptions.RemoveEmptyEntries);
    string contestName = tokens[0];
    string password = tokens[1];

    if (!contestPass.ContainsKey(contestName))
    {
        contestPass.Add(contestName, password);
    }
    else
    {
        contestPass[contestName] = password;
    }
}

string userInput;
while ((userInput = Console.ReadLine()) != "end of submissions")
{
    string[] tokens = userInput
        .Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string contest = tokens[0];
    string password = tokens[1];
    string user = tokens[2];
    int points = int.Parse(tokens[3]);

    if (contestPass.ContainsKey(contest) && contestPass[contest] == password)
    {
        if (!userInfo.ContainsKey(user))
        {
            userInfo.Add(user, new Dictionary<string, int>());
        }
        if (!userInfo[user].ContainsKey(contest))
        {
            userInfo[user].Add(contest,points);
        }
        if (points < userInfo[user][contest])
        {
            continue;
        }
        userInfo[user][contest] = points;
    }
}
string bestCandidate = string.Empty;
int bestPoints = int.MinValue;

foreach (var user in userInfo)
{
    int userPoints = 0;

    foreach (var contest in user.Value)
    {
        userPoints += contest.Value;
    }
    if (userPoints > bestPoints)
    {
        bestPoints = userPoints;
        bestCandidate = user.Key;
    }
}
userInfo = userInfo
    .OrderBy(x => x.Key)
    .ToDictionary(x => x.Key,x => x.Value);

Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");
Console.WriteLine("Ranking:");

foreach (var user in userInfo)
{
    Console.WriteLine(user.Key);

    foreach (var contest in user.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}