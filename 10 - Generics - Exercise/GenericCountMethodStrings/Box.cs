

using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            Values = new List<T>();
        }
        public List<T> Values { get; set; }


        public override string ToString()
        {
            return $"{typeof(T).ToString()}: {Values.ToString()}";
        }

        public void Add(T value)
        {
            Values.Add(value);
        }

        public int CompareTo(T value)
        {
            int count = 0;
            foreach (T item in Values)
            {
                if (item.CompareTo(value) > 0) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}
