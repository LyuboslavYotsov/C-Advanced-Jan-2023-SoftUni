using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIteratorNS
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex = 0;

        private List<T> elements;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements.ToList());
        }

        public bool Move()
        {
            if (currentIndex + 1 < elements.Count)
            {
                currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            return currentIndex < elements.Count - 1;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(elements[currentIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                foreach (var item in elements)
                {
                    yield return item;
                }
            }
        }
        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",elements));
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
