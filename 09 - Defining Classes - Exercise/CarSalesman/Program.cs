using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            int engineCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineInfo);
                engines.Add(engineInfo[0], engine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carInfo, engines);
                cars.Add(car);
            }


            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static Engine CreateEngine(string[] engineInfo)
        {
            string model = engineInfo[0];
            int power = int.Parse(engineInfo[1]);
            Engine engine = new Engine(model, power);

            if (engineInfo.Length > 2)
            {
                int displacement;

                bool isDigit = int.TryParse(engineInfo[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }
                if (engineInfo.Length > 3)
                {
                    engine.Efficiency = engineInfo[3];
                }
            }

            return engine;
        }

        private static Car CreateCar(string[] carInfo, Dictionary<string, Engine> engines)
        {
            string model = carInfo[0];
            Engine engine = engines[carInfo[1]];
            Car car = new Car(model, engine);

            if (carInfo.Length > 2)
            {
                int weight;
                bool isDigit = int.TryParse(carInfo[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInfo[2];
                }
                if (carInfo.Length > 3)
                {
                    car.Color = carInfo[3];
                }
            }

            return car;
        }
    }
}
