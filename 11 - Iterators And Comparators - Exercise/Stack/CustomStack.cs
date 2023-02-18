

using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public CustomStack()
        {
            this.elements = new List<T>();
        }

        public void Push(T element)
        {
            elements.Insert(0, element);
        }

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T currentElement = elements[0];
            elements.RemoveAt(0);
            return currentElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
