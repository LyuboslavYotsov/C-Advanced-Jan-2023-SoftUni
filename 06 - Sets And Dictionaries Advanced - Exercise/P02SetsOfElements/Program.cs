using System;
using System.Collections.Generic;
using System.Linq;

int[] counts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int firstCount = counts[0];
int secondCount = counts[1];
HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();
for (int i = 0; i < firstCount; i++)
{
    int number = int.Parse(Console.ReadLine());
    firstSet.Add(number);
}

for (int i = 0; i < secondCount; i++)
{
    int number = int.Parse(Console.ReadLine());
    secondSet.Add(number);
}
firstSet.IntersectWith(secondSet);
Console.WriteLine(string.Join(" ", firstSet));