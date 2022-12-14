Random rand = new Random();
int rows = GetNumber("Enter rows count: ");
int columns = GetNumber("Enter columns count: ");
int[,] matrix = CreateMatrix(rows, columns);
int searchRow = GetNumber("Enter row index to search: ");
int searchColumn = GetNumber("Enter column index to search: ");
PrintMatrix(matrix);
Console.WriteLine();
GetSearchedElement(matrix, searchRow, searchColumn);

void GetSearchedElement(int[,] matrix, int searchRow, int searchColumn)
{
    if (matrix.GetLength(0) < searchRow || matrix.GetLength(1) < searchColumn)
    {
        System.Console.WriteLine("This array doesn't contains number in entered position");
    }
    else
    {
        System.Console.Write($"An element in the index [{searchRow}][{searchColumn}] ");
        Sleep();
        System.Console.Write(" is ");
        Sleep();
        System.Console.Write(" ... ");
        Sleep();
        System.Console.Write(matrix[searchRow, searchColumn]);
    }
}

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

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Sleep()
{
    System.Threading.Thread.Sleep(1000);

}
// bool SearchElements(int[,] matr, int searcRow, int searchColumn)
// {
//     bool flag = false;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[searcRow, searchColumn] == matr[i, j]) flag = true;
//         }
//     }
//     return flag;
// }

// try
// {
//     if (SearchElements(matrix, searchRow, searchColumn))
//     {
//         System.Console.WriteLine("searched element is: " + matrix[searchRow, searchColumn]);
//     }
// catch (System.IndexOutOfRangeException)
// {
//     System.Console.WriteLine("Youre out of bound, mister");