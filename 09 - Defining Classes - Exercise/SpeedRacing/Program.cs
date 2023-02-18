
using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumtion = double.Parse(carInfo[2]);

                Car currCar = new Car(model, fuelAmount, fuelConsumtion);
                cars.Add(currCar);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End") 
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = commandArgs[1];
                int distance = int.Parse(commandArgs[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        car.Drive(distance);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
