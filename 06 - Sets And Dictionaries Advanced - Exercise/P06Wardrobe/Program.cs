using System;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> clothesByColor = new Dictionary<string, Dictionary<string, int>>();
for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine()
        .Split(new string[] {" -> ",","}, StringSplitOptions.RemoveEmptyEntries);
    
    string color = input[0];
    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor.Add(color, new Dictionary<string, int>());
    }
    for (int j = 1; j < input.Length; j++)
    {
        string clothing = input[j];
        if (!clothesByColor[color].ContainsKey(clothing))
        {
            clothesByColor[color].Add(clothing, 0);
        }
        clothesByColor[color][clothing]++;
    }
}
string[] target = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string targetColor = target[0];
string targetClothing = target[1];

foreach (var color in clothesByColor)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var clothing in color.Value)
    {
        Console.Write($"* {clothing.Key} - {clothing.Value}");
        if (color.Key == targetColor && clothing.Key == targetClothing)
        {
            Console.Write($" (found!)");
        }
        Console.WriteLine();
    }
}