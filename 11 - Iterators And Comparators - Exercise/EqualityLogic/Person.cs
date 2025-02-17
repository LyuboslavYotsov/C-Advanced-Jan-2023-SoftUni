﻿using System;
namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return Name == other.Name && Age == other.Age;
        }
    }
}
