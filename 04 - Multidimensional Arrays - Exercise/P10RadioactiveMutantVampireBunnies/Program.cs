using System;
using System.Linq;

int[] dimensions = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];
int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    string chars = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = chars[col];
        if (chars[col] == 'P')
        {
            playerRow = row;
            playerCol = col;
            matrix[playerRow, playerCol] = '.';
        }
    }
}
string directions = Console.ReadLine();

foreach (char direction in directions)
{
    int lastPlayerRow = playerRow;
    int lastPlayerCol = playerCol;
    
    if (direction == 'L')
    {
        playerCol--;
    }
    else if (direction == 'R')
    {
        playerCol++;
    }
    else if (direction == 'U')
    {
        playerRow--;
    }
    else if (direction == 'D')
    {
        playerRow++;
    }

    matrix = SpreadBunnies();

    if (playerRow < 0 || playerRow >= rows || playerCol < 0 || playerCol >= cols)
    {
        PrintMatrix();
        Console.WriteLine($"won: {lastPlayerRow} {lastPlayerCol}");
        break;
        
    }
    if (matrix[playerRow,playerCol] == 'B')
    {
        PrintMatrix();
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        break;
    }
}

char[,] SpreadBunnies()
{
    char[,] newMatrix = new char[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            newMatrix[row, col] = matrix[row, col];
        }
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row,col] == 'B')
            {
                if (row > 0)
                {
                    newMatrix[row - 1, col] = 'B';
                }
                if (row < rows - 1)
                {
                    newMatrix[row + 1, col] = 'B';
                }
                if (col > 0)
                {
                    newMatrix[row, col - 1] = 'B';
                }
                if (col < cols - 1)
                {
                    newMatrix[row, col + 1] = 'B';
                }
            }
        }
    }

    return newMatrix;
}

void PrintMatrix()
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row,col]);
        }
        Console.WriteLine();
    }
}