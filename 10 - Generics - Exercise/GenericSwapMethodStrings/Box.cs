using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public Box()
        {
            Value = new List<T>();
        }
        public List<T> Value { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in Value)
            {
                sb.AppendLine($"{typeof(T).ToString()}: {element}");
            }
            return sb.ToString();
        }

        public void Add(T value)
        {
            Value.Add(value);
        }
        public void SwapElements(int index1,int index2)
        {
            T current = Value[index1];
            Value[index1] = Value[index2];
            Value[index2] = current;
        }
    }
}
