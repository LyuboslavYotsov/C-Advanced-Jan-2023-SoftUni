using System;
using System.Collections.Generic;
using System.Linq;

int[] inputData = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();


int rows = inputData[0];
int cols = inputData[1];
int sum = 0;
int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
        sum += input[col];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);

int[,] test =
{
    {1, 2 ,3 },
    {1 , 2 ,3 }
};
for (int i = 0; i < test.GetLength(0); i++)
{
    for (int j = 0; j < test.GetLength(1); j++)
    {
        Console.Write(test[i,j]);
    }
    Console.WriteLine();
}