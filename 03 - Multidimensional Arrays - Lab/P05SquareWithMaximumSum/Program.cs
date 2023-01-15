using System;
using System.Linq;

namespace P05SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputInfo = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = inputInfo[0];
            int cols = inputInfo[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int maxSum = int.MinValue;
            int minRow = 0;
            int minCol = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = 0;
                    sum += matrix[row, col];
                    sum += matrix[row + 1, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        minRow = row;
                        minCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[minRow,minCol]} {matrix[minRow,minCol + 1]}");
            Console.WriteLine($"{matrix[minRow + 1, minCol]} {matrix[minRow + 1, minCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
