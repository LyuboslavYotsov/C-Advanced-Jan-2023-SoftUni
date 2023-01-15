using System;
using System.Linq;

namespace P06JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = inputNumbers;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commArgs = input
                    .Split();
                string command = commArgs[0];

                if (command == "Add")
                {
                    int row = int.Parse(commArgs[1]);
                    int col = int.Parse(commArgs[2]);
                    int value = int.Parse(commArgs[3]);

                    if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(commArgs[1]);
                    int col = int.Parse(commArgs[2]);
                    int value = int.Parse(commArgs[3]);

                    if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ",jagged[i]));
            }
        }



    }
}
