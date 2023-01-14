using System;
using System.Collections.Generic;

namespace P10Crossroads2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenTime = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int carPassed = 0;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {  
                if (input != "green")
                {
                    cars.Enqueue(input);
                    continue;
                }
                int currentGreen = greenTime;

                while (currentGreen > 0 && cars.Count > 0)
                {
                    string currentCar = cars.Dequeue();

                    if (currentGreen - currentCar.Length >= 0)
                    {
                        currentGreen -= currentCar.Length;
                        carPassed++;
                        continue;
                    }
                    if (currentGreen + freeTime - currentCar.Length >= 0)
                    {
                        currentGreen = 0;
                        carPassed++;
                        continue;
                    }

                    int hittedChar = currentGreen + freeTime;
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentCar[hittedChar]}");
                    Environment.Exit(0);
                }

            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carPassed} cars passed the crossroads.");
        }
    }
}
