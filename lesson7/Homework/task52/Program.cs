Random rand = new Random();

int rows = GetNumberFromString("Enter rows quantity: ");
int columns = GetNumberFromString("Enter columns quantity: ");
int[,] matrixx = CreateMatrix(rows, columns);
PrintMatrix(matrixx);
ArithmeticMean(matrixx, rows, columns);

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
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

int GetNumberFromString(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ArithmeticMean(int[,] matr, int rows, int columns)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            arithmeticMean += matr[i, j];
        }
        arithmeticMean /= rows;
        Console.WriteLine( j+1 + "-й столбец, среднее арифметическое = " + arithmeticMean + ";");
    }
}
