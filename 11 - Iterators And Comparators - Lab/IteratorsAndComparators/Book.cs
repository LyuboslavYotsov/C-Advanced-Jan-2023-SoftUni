﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book 
    {
        
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors.ToList());

        }
        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }
        public override string ToString() 
        {
            return $"{Title} - {Year}";
        }
    }
}
