using System;
using System.Linq;

int[] sizes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = sizes[0];
int cols = sizes[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}
int maxSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;
for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum = 0;
        currentSum += matrix[row, col];
        currentSum += matrix[row, col + 1];
        currentSum += matrix[row, col + 2];
        currentSum += matrix[row + 1, col];
        currentSum += matrix[row + 1, col + 1];
        currentSum += matrix[row + 1, col + 2];
        currentSum += matrix[row + 2, col];
        currentSum += matrix[row + 2, col + 1];
        currentSum += matrix[row + 2, col + 2];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxRow = row;
            maxCol = col;
        }
    }
}
Console.WriteLine($"Sum = {maxSum}");
for (int row = maxRow; row < maxRow + 3; row++)
{
    for (int col = maxCol; col < maxCol + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}



static void PrintArray(int[,] matrix)
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