using GenericBoxOfString;
using System;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string value = Console.ReadLine();
    Box<string> newBox = new(value);
    Console.WriteLine(newBox.ToString());
}