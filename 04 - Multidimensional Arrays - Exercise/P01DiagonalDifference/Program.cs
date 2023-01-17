using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size,size];
int primarySum = 0;
int secondarySum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }

}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    primarySum += matrix[row, row];
}
for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
{
    secondarySum += matrix[i, matrix.GetLength(0) - i - 1];
}
Console.WriteLine(Math.Abs(primarySum - secondarySum));



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

