﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }
        public T Value { get; set; }


        public override string ToString()
        {
            return $"{typeof(T).ToString()}: {Value.ToString()}";
        }
    }

}
