using EqualityLogic;
using System;
using System.Collections.Generic;

SortedSet<Person> sorted = new();
HashSet<Person> hashed = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] personInfo = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
    sorted.Add(currentPerson);
    hashed.Add(currentPerson);
}

Console.WriteLine(sorted.Count);
Console.WriteLine(hashed.Count);