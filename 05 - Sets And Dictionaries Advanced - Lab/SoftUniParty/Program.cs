using System;
using System.Collections.Generic;

HashSet<string> vip = new HashSet<string>();
HashSet<string> regular = new HashSet<string>();

string input;
while ((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vip.Add(input);
    }
    else
    {
        regular.Add(input);
    }

}
while ((input = Console.ReadLine()) !="END")
{
    if (char.IsDigit(input[0]))
    {
        if (vip.Contains(input))
        {
            vip.Remove(input);
        }
    }
    else
    {
        if (regular.Contains(input))
        {
            regular.Remove(input);
        }
    }
}
Console.WriteLine(regular.Count + vip.Count);
if (vip.Count > 0)
{
    foreach (var guest in vip)
    {
        Console.WriteLine(guest);
    }
}
if (regular.Count > 0)
{
    foreach (var guest in regular)
    {
        Console.WriteLine(guest);
    }
}
