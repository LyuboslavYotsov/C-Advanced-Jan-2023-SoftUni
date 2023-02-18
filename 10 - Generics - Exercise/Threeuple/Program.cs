using System;
using ThreeupleNS;


Threeuple<string, string, string> firstThreeuple = new();
Threeuple<string, int, bool> secondThreeuple = new ();
Threeuple<string, double,string> thirdThreeuple = new ();

for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ');

    if (i == 0)
    {
        firstThreeuple.item1 = input[0] + " " + input[1];
        firstThreeuple.item2 = input[2];
        firstThreeuple.item3 = input[3];
    }
    else if (i == 1)
    {
        secondThreeuple.item1 = input[0];
        secondThreeuple.item2 = int.Parse(input[1]);
        secondThreeuple.item3 = input[2] == "drunk";
    }
    else if (i == 2)
    {
        thirdThreeuple.item1 = input[0];
        thirdThreeuple.item2 = double.Parse(input[1]);
        thirdThreeuple.item3 = input[2];
    }
}

Console.WriteLine(firstThreeuple.ToString());
Console.WriteLine(secondThreeuple.ToString());
Console.WriteLine(thirdThreeuple.ToString());
