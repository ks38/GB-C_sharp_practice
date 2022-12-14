Random rand = new Random();
int rows = GetNumber("Enter rows count: ");
int columns = GetNumber("Enter columns count: ");
double[,] matrix = CreateMatrix(rows, columns);
PrintMatrix(matrix);

double[,] CreateMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((GetRandomNumberInRange(-10, 10)), 1);
        }
    }
    return matrix;
}

double GetRandomNumberInRange(int minNumber, int maxNumber)
{
    return rand.NextDouble() * (maxNumber - minNumber) + minNumber;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
