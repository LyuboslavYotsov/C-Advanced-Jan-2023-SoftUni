using System;
using System.Collections.Generic;

List<string> items = new List<string>
{
    "BuBo",
    "oBuB",
    "NoFear"
};

List<int> nums = new()
{
    1,
    2,
    3,
    4
};

Print(items);
Print(nums);
void Print<T>(List<T> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}