using System;
using System.Collections.Generic;
using System.Linq;

namespace P07TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<Pump> queue = new Queue<Pump>();
            int index = 0;
            for (int i = 0; i < pumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split (' ')
                    .Select(int.Parse)
                    .ToArray();

                int fuel = input[0];
                int distance = input[1];
                Pump currPump = new Pump(fuel, distance);
                queue.Enqueue(currPump);
            }

            while (true)
            {
                bool isCopmplete = true;
                int totalFuel = 0;

                foreach (Pump pump in queue)
                {
                    totalFuel += pump.Fuel;

                    if (totalFuel - pump.Distance < 0)
                    {
                        index++;
                        Pump currPump = queue.Dequeue();
                        queue.Enqueue(currPump);
                        isCopmplete = false;
                        break;
                    }
                    totalFuel -= pump.Distance;
                }
                if (isCopmplete)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
            
        }
    }

    public class Pump
    {
        public Pump(int fuel, int distance)
        {
             this.Fuel = fuel;
            this.Distance = distance;
        }
        public int Fuel { get; set; }

        public int Distance { get; set; }
    }
}
