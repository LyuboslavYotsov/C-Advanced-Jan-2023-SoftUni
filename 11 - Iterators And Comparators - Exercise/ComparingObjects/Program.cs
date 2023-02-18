using ComparingObjects;
using System;
using System.Collections.Generic;

List<Person> people = new List<Person>();

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] personInfo = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
    people.Add(currentPerson);
}
int personNumber = int.Parse(Console.ReadLine());
Person personToCompare = people[personNumber - 1];
int different = 0;
int equal = 0;

foreach (var person in people)
{
    if (person.CompareTo(personToCompare) == 0) 
    {
        equal++;
    }
    else
    {
        different++;
    }
}

if (equal == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{equal} {different} {people.Count}");
}