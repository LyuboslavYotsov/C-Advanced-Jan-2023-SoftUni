using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = string.Empty;
Action<List<int>> print = numbers =>
{
    Console.WriteLine(string.Join(" ",numbers));
};

while ((command = Console.ReadLine()) != "end")
{
    if (command != "print")
    {
        Func<int, int> opeartion = CalculationType(command);

        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = opeartion(numbers[i]);
        }
        continue;
    }
    print(numbers);
}


Func<int, int> CalculationType(string command)
{
    if (command == "add")
    {
        return n => n + 1;
    }
    else if (command == "subtract")
    {
        return n => n - 1;
    }
    else
    {
        return n => n * 2;
    }

}