using System;
using System.Linq;

int rows = int.Parse(Console.ReadLine());
int[][] numbers= new int[rows][];

for (int row = 0; row < numbers.Length; row++)
{
    int[] input = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    numbers[row] = input;
}

for (int row = 0; row < numbers.Length - 1; row++)
{
    if (numbers[row].Length == numbers[row + 1].Length)
    {
        for (int col = 0; col < numbers[row].Length; col++)
        {
            numbers[row][col] *= 2;
            numbers[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < numbers[row].Length; col++)
        {
            numbers[row][col] /= 2;
           
        }
        for (int col2 = 0; col2 < numbers[row + 1].Length; col2++)
        {
            numbers[row + 1][col2] /= 2;
        }
    }
}

string commands;
while ((commands = Console.ReadLine()) != "End")
{
    string[] commandArgs = commands
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandArgs[0];
    int row = int.Parse(commandArgs[1]);
    int col = int.Parse(commandArgs[2]);
    int value = int.Parse(commandArgs[3]);
    if (row < 0 || row >= numbers.Length || col < 0 || col >= numbers[row].Length)
    {
        continue;
    }
    if (command == "Add")
    {
        numbers[row][col] += value;
    }
    else if (command == "Subtract")
    {
        numbers[row][col] -= value;
    }
}
PrintArray(numbers);
static void PrintArray(int[][] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write(matrix[i][j] + " ");
        }
        Console.WriteLine();
    }
}