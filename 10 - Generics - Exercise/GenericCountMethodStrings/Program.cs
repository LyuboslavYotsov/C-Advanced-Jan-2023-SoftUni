using GenericCountMethodStrings;
using System;
Console.Beep();
int n = int.Parse(Console.ReadLine());

Box<string> stringBox = new Box<string>();
for (int i = 0; i < n; i++)
{
    string value = Console.ReadLine();
    stringBox.Add(value);
}

string elementToCompare = Console.ReadLine();

Console.WriteLine(stringBox.CompareTo(elementToCompare));