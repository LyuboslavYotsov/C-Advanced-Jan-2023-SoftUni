using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
string[] moves = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

char[,] matrix = new char[size, size];
int minerRow = 0;
int minerCol = 0;
int totalToCollect = 0;
for (int row = 0; row < size; row++)
{
    char[] chars = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = chars[col];
        if (chars[col] == 's')
        {
            minerRow = row;
            minerCol = col;
        }
        if (chars[col] == 'c')
        {
            totalToCollect++;
        }
    }
}

foreach (var direction in moves)
{
    int lastMinerRow = minerRow;
    int lastMinerCol = minerCol;

    if (direction == "left" && minerCol > 0)
    {
        minerCol--;
    }
    else if (direction == "right" && minerCol < size - 1)
    {
        minerCol++;
    }
    else if (direction == "up" && minerRow > 0)
    {
        minerRow--;
    }
    else if (direction == "down" && minerRow < size - 1)
    {
        minerRow++;
    }

    if (matrix[minerRow,minerCol] == 'c')
    {
        totalToCollect--;
        matrix[minerRow, minerCol] = '*';

        if (totalToCollect == 0)
        {
            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
            return;
        }
    }
    else if (matrix[minerRow,minerCol] == 'e')
    {
        Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
        return;
    }

}
Console.WriteLine($"{totalToCollect} coals left. ({minerRow}, {minerCol})");