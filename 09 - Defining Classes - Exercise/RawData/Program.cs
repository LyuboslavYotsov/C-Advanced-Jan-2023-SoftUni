using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);

                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);

                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);

                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Engine currEngine = new Engine(engineSpeed, enginePower);
                Cargo currCargo = new Cargo(cargoWeight, cargoType);
                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);

                Car currCar = new Car (model , currEngine , currCargo , tire1,tire2, tire3, tire4);
                cars.Add(currCar);

            }

            string filter = Console.ReadLine();
            List<Car> filteredCars = new List<Car>();
            if (filter == "fragile")
            {
                filteredCars = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tire1.Pressure < 1 || c.Tire2.Pressure < 1 || c.Tire3.Pressure < 1 || c.Tire4.Pressure < 1)
                    .ToList();
            }
            else
            {
                filteredCars = cars
                    .Where(c => c.Cargo.Type == "flammable")
                    .Where(c => c.Engine.Power > 250)
                    .ToList();
            }

            foreach (var car in filteredCars)
            {
                Console.WriteLine(car.Model);
            }

            List<Car> filterWithoutLinq = new List<Car>();

            if (filter == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        if (car.Tire1.Pressure < 1 || car.Tire2.Pressure < 1 || car.Tire3.Pressure < 1 || car.Tire4.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
            else if (filter == "flammable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "flammable")
                    {
                        if (car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
            //foreach (var car in filterWithoutLinq)
            //{
            //    Console.WriteLine(car.Model);
            //}
        }
    }
}
