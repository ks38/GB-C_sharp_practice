int[,] CreateMatrix(int rows, int columns)
{
    Random rand = new Random();
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
                    int tmp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = tmp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix(5, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);
