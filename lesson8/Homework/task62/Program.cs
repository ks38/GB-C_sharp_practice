﻿int n = 4;
int[,] matr = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matr.GetLength(0) * matr.GetLength(1))
{
    matr[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matr.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matr.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintMatrix(matr);
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] / 10 <= 0)
                Console.Write($" {matr[i, j]} ");

            else Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}