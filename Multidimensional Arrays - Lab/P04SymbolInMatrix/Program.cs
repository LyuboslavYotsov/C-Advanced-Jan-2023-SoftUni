using System;

int n = int.Parse(Console.ReadLine());

char[,] charMatrix = new char[n,n];

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
			for (int col = 0; col < charMatrix.GetLength(1); col++)
			{
				charMatrix[i, col] = input[col];
			}
		
}
char targetSymbol = char.Parse(Console.ReadLine());
bool targetFound = false;
int targetRow = 0;
int targetCol = 0;
for (int row = 0; row < charMatrix.GetLength(0); row++)
{
	for (int col = 0; col < charMatrix.GetLength(1); col++)
	{
		if (charMatrix[row,col] == targetSymbol)
		{
			targetFound = true;
			targetRow = row;
			targetCol = col;
			break;
		}
		
	}
    if (targetFound)
    {
        break;
    }

}
if (targetFound)
{
	Console.WriteLine($"({targetRow}, {targetCol})");
}
else
{
	Console.WriteLine($"{targetSymbol} does not occur in the matrix");
}





////for (int row = 0; row < charMatrix.GetLength(0); row++)
//{
//	for (int col = 0; col < charMatrix.GetLength(1); col++)
//	{
//		Console.Write(charMatrix[row,col]);
//	}
//	Console.WriteLine();
//}