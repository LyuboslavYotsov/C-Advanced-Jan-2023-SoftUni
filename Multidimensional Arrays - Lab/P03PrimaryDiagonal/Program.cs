using System;
using System.Linq;

int[] inputData = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();


int rows = inputData[0];
//int cols = inputData[1];
int[,] matrix = new int[rows, rows];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}
int diagonalSum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    diagonalSum += matrix[row,row];
}
Console.WriteLine(diagonalSum);
