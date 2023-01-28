using System;
using System.Linq;

Func<double,double> vat = number => number * 1.20;
double[] prices = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(vat)
    .ToArray();

foreach (var price in prices)
{
    Console.WriteLine($"{price:f2}");
}