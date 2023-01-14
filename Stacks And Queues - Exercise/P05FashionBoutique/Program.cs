using System;
using System.Collections.Generic;
using System.Linq;

int[] clothes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(clothes);
int rackVolume = int.Parse(Console.ReadLine());
int rack = rackVolume;
int racksCount = 1;

while (stack.Any())
{
    if (rack - stack.Peek() >= 0)
    {
        rack -= stack.Pop();
    }
    else
    {
        racksCount++;
        rack = rackVolume;
    }
}
Console.WriteLine(racksCount);