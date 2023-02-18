using GenericBoxOfInteger;
using System;


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int value = int.Parse(Console.ReadLine());
    Box<int> newBox = new(value);
    Console.WriteLine(newBox.ToString());
}