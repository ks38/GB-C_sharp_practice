void CreateMatrix(int[,,] matr)
{
    Random rand = new Random();
    int[] tmp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    int number;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        tmp[i] = rand.Next(10, 20);
        number = tmp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tmp[i] == tmp[j])
                {
                    tmp[i] = rand.Next(10, 20);
                    j = 0;
                    number = tmp[i];
                }
                number = tmp[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = tmp[count];
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}); \n");
            }
        }
        Console.WriteLine();
    }
}

int x = 3;
int y = 3;
int z = 3;

int[,,] matrix3D = new int[x, y, z];
CreateMatrix(matrix3D);
PrintMatrix(matrix3D);
