using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            string tireInput = string.Empty;
            while ((tireInput = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = tireInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire tire1 = new Tire(int.Parse(tiresInfo[0]), double.Parse(tiresInfo[1]));
                Tire tire2 = new Tire(int.Parse(tiresInfo[2]), double.Parse(tiresInfo[3]));
                Tire tire3 = new Tire(int.Parse(tiresInfo[4]), double.Parse(tiresInfo[5]));
                Tire tire4 = new Tire(int.Parse(tiresInfo[6]), double.Parse(tiresInfo[7]));
                Tire[] currentTires = new Tire[] { tire1, tire2, tire3, tire4 };
                tires.Add(currentTires);

            }

            string engineInput = string.Empty;
            List<Engine> engineList = new List<Engine>();
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = engineInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engineInfo[0]);
                double cubics = double.Parse(engineInfo[1]);
                Engine currEngine = new Engine(horsePower, cubics);
                engineList.Add(currEngine);
            }

            string carsInput = string.Empty;
            List<Car> carList = new List<Car>();
            while ((carsInput = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = carsInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);

                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tires[tireIndex]);
                carList.Add(currentCar);

            }
            
            if (carList.Any())
            {

                foreach (var car in carList
                    .Where(car => car.Year >= 2017)
                    .Where(car => car.Engine.HorsePower > 330))

                {
                    double pressureSum = 0;
                    foreach (var tire in car.Tires)
                    {
                        pressureSum += tire.Pressure;
                    }
                    if (pressureSum > 9 && pressureSum < 10)
                    {
                        car.Drive(20);
                        Console.WriteLine(car.WhoAmI());
                    }


                }
            }
        }
    }
}
