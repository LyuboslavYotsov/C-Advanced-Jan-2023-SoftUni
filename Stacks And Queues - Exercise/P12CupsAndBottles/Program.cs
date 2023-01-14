using System;
using System.Collections.Generic;
using System.Linq;

namespace P10Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInput = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(bottlesInput);
            Queue<int> cups = new Queue<int>(cupsInput);
            int wastedWater = 0;
            int waterFromLast = 0;

            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currBottle = bottles.Pop() + waterFromLast;
                int currCup = cups.Peek();

                if (currBottle - currCup >= 0)
                {
                    wastedWater += currBottle - currCup;
                    cups.Dequeue();
                    waterFromLast = 0;
                }
                else
                {
                    waterFromLast = currBottle;
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
