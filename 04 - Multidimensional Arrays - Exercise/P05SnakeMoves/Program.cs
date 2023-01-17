using System;
using System.Collections.Generic;
using System.Linq;

int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];
string snake = Console.ReadLine();
Queue<char> queue = new Queue<char>(snake);

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            char currCh = queue.Dequeue();
            matrix[row, col] = currCh;
            queue.Enqueue(currCh);
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            char currCh = queue.Dequeue();
            matrix[row, col] = currCh;
            queue.Enqueue(currCh);
        }
    }
}
PrintArray(matrix);
static void PrintArray(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}