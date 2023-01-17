using System;

int size = int.Parse(Console.ReadLine());

char[,] board = new char[size,size];

for (int row = 0; row < size; row++)
{
    string chars = Console.ReadLine();

	for (int col = 0; col < size; col++)
	{
		board[row, col] = chars[col];
	}
}

int removedKnights = 0;

while (true)
{
    int mostAttackedCount = 0;
    int mostAttackedRow = 0;
    int mostAttackedCol = 0;

	for (int row = 0; row < size; row++)
	{
		for (int col = 0; col < size; col++)
		{
			if (board[row,col] == 'K')
			{
				int attackedKnights = CountAttackedKnights(row, col);
                if (attackedKnights > mostAttackedCount)
                {
                    mostAttackedCount = attackedKnights;
                    mostAttackedRow = row;
                    mostAttackedCol = col;
                }
			}
		}
	}



    if (mostAttackedCount == 0)
	{
		break;
	}
	else
	{
		board[mostAttackedRow, mostAttackedCol] = '0';
		removedKnights++;
	}
}


bool IsCellValid(int row, int col)
{
	return row >= 0 && row < size && col >= 0 && col < size;
}
int CountAttackedKnights(int row, int col)
{
	int attackedKnights = 0;

	if (IsCellValid(row - 1, col - 2))
	{
		if (board[row - 1, col - 2] == 'K')
		{
			attackedKnights++;
		}
	}
    if (IsCellValid(row + 1, col - 2))
    {
        if (board[row + 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 1, col + 2))
    {
        if (board[row - 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row + 1, col + 2))
    {
        if (board[row + 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row + 2, col - 1))
    {
        if (board[row + 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row + 2, col + 1))
    {
        if (board[row + 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 2, col - 1))
    {
        if (board[row - 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }
    if (IsCellValid(row - 2, col + 1))
    {
        if (board[row - 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    return attackedKnights;
}

Console.WriteLine(removedKnights);