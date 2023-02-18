using System;
using System.Collections.Generic;
using ToupleNS;

Touple<string,string> firstTouple = new Touple<string,string>();
Touple<string,int> secondTouple = new Touple<string,int>();
Touple<int,double> thirdTouple = new Touple<int,double>();

for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine()
        .Split(' ');

    if (i == 0)
    {
        firstTouple.Item1 = input[0] + " " + input[1];
        firstTouple.Item2 = input[2];
    }
    else if (i == 1)
    {
        secondTouple.Item1 = input[0];
        secondTouple.Item2 = int.Parse(input[1]);
    }
    else if (i == 2)
    {
        thirdTouple.Item1 = int.Parse(input[0]);
        thirdTouple.Item2 = double.Parse(input[1]);
    }
}

Console.WriteLine(firstTouple.ToString());
Console.WriteLine(secondTouple.ToString());
Console.WriteLine(thirdTouple.ToString());
