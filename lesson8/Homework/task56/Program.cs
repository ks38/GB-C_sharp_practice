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


void SumRows(int[,] matr)
{
    int minSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (i == 0) minSum = sum;
        else if (sum < minSum) minSum = sum;
        System.Console.WriteLine("sum of " + (i + 1) + " row = " + sum);
    }
    System.Console.WriteLine("min sum = " + minSum);
}


int[,] matrix = CreateMatrix(5, 5);
PrintMatrix(matrix);
System.Console.WriteLine();
SumRows(matrix);