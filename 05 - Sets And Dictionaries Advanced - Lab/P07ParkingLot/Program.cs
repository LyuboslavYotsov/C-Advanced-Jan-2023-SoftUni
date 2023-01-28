using System;
using System.Collections.Generic;

HashSet<string> cars = new HashSet<string>();
string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] commArgs = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string command = commArgs[0];
    string carNumber = commArgs[1];

    if (command == "IN")
    {
        cars.Add(carNumber);
    }
    else if (command == "OUT")
    {
        if (cars.Contains(carNumber))
        {
            cars.Remove(carNumber);
        }
    }
}
if (cars.Count > 0)
{
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}