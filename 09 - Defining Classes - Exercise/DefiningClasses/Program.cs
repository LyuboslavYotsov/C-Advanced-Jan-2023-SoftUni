using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Family family= new Family();
            for (int i = 0; i < count; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person currentPerson = new Person(name,age);

                family.AddMember(currentPerson);
            }

            List<Person> filteredMembers = family.People
                .OrderBy(p => p.Name)
                .Where(p => p.Age > 30)
                .ToList();

            foreach (var person in filteredMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
