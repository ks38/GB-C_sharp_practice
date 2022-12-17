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


void MultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] newMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            newMatrix[i, j] = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                newMatrix[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    PrintMatrix(newMatrix);
}

int rows = 4;
int columns = 4;
int[,] matrix = CreateMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] matrix2 = CreateMatrix(rows, columns);
PrintMatrix(matrix2);
System.Console.WriteLine();
MultMatrix(matrix, matrix2);