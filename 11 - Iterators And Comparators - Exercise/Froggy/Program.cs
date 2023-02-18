using Froggy;
using System;
using System.Linq;

int[] input = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();


Lake lake = new Lake(input);

Console.WriteLine(string.Join(", ", lake));