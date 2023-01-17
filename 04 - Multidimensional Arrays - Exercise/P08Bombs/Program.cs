using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

string[] coordinates = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var bomb in coordinates)
{
    int bombRow = int.Parse(bomb[0].ToString());
    int bombCol = int.Parse(bomb[2].ToString());
    int bombPower = matrix[bombRow, bombCol];

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (row == bombRow && col == bombCol && matrix[bombRow, bombCol] > 0)
            {
                matrix[row, col] -= bombPower;

                if (row > 0 && matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= bombPower;
                }
                if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= bombPower;
                }
                if (row > 0 && col < size - 1 && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= bombPower;
                }
                if (col > 0 && matrix[row, col - 1] > 0)
                {
                    matrix[row, col - 1] -= bombPower;
                }
                if (col < size - 1 && matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= bombPower;
                }
                if (row < size - 1 && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= bombPower;
                }
                if (row < size - 1 && col > 0 && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= bombPower;
                }
                if (row < size - 1 && col < size - 1 && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= bombPower; 
                }
            }
        }
    }
}
int aliveCells = 0;
int aliveCellsSum = 0;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row,col] > 0)
        {
            aliveCells++;
            aliveCellsSum += matrix[row,col];
        }
    }
}
Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {aliveCellsSum}");
PrintMatrix();




void PrintMatrix()
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}