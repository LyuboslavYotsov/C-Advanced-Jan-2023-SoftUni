using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(", ");
    Person currentPerson = new Person(input[0], int.Parse(input[1]));
    people.Add(currentPerson);
}
string condition = Console.ReadLine();
int value = int.Parse(Console.ReadLine());
string printFormat = Console.ReadLine();
Func<Person, int, bool> filterByAge = Filter(condition);

people = people
    .Where(p => filterByAge(p, value))
    .ToList();
Action<Person> print = PrintFormat(printFormat);

foreach (var person in people)
{
    print(person);
}



Action<Person> PrintFormat (string format)
{
    if (format == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    if (format == "name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    if (format == "age")
    {
        return p => Console.WriteLine($"{p.Age}");
    }
    return null;
}
static Func<Person,int,bool> Filter(string condition)
{
    if (condition == "younger")
    {
        return (p, value) => p.Age < value;
    }
    else
    {
        return (p, value) => p.Age >= value;
    }
};

class Person
{
    public Person(string name , int age)
    {
        Name= name;
        Age= age;
    }
    public string Name { get; set; }

    public int Age { get; set; }
}