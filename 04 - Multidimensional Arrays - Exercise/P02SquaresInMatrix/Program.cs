using System;
using System.Linq;

int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] matrix = new char[size[0], size[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] input = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}
int count = 0;
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        char currCh = matrix[row, col];

        if (currCh == matrix[row + 1, col] && currCh == matrix[row, col + 1] &&
            currCh == matrix[row + 1, col + 1])
        {
            count++;
        }
        
    }
}
Console.WriteLine(count);






static void PrintArray(char[,] matrix)
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