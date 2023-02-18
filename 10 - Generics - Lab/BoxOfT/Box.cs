

using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;
        private int count;

        public Box()
        {
            list = new List<T>();
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T element)
        {
            list.Add(element);
            count++;
        }

        public T Remove()
        {
            T element = list[count - 1];
            list.RemoveAt(count - 1);
            count--;
            return element;
        }
    }
}
