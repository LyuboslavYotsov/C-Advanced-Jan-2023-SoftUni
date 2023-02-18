using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person= new Person 
            {
                Age= 1,
                Name = "Pesho"
            };

            Console.WriteLine(person.Name);
        }
    }
}
