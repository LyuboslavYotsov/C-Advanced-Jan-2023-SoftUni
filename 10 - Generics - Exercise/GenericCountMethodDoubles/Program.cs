using GenericCountMethodDoubles;
using System;

int n = int.Parse(Console.ReadLine());

Box<double> stringBox = new Box<double>();
for (int i = 0; i < n; i++)
{
    double value = double.Parse(Console.ReadLine());
    stringBox.Add(value);
}

double elementToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(stringBox.CompareTo(elementToCompare));

