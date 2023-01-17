using System;
using System.Linq;

int[] sizes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = sizes[0];
int cols = sizes[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}
string commands;
while ((commands = Console.ReadLine()) != "END")
{
    string[] tokens = commands
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];
    if (command != "swap" || tokens.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    int row1 = int.Parse(tokens[1]);
    int col1 = int.Parse(tokens[2]);
    int row2 = int.Parse(tokens[3]);
    int col2 = int.Parse(tokens[4]);
    if (row1 < 0 || row1 >= rows || col1 < 0 || col1 >= cols || row2 < 0 || row2 >= rows || col2 < 0 || col2 >= cols) 
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    string currValue = matrix[row1,col1];
    string newValue = matrix[row2,col2];
    matrix[row1,col1] = newValue;
    matrix[row2,col2] = currValue;
    PrintArray(matrix);

}
static void PrintArray(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}