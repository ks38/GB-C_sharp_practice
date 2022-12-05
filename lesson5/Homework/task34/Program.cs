int[] array = new int[10];
RandomizeArray(array);
PrintArray(array);
EvenCount(array);

void RandomizeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine($"[{string.Join(", ", arr)}]");
}

void EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("Even elements: " + count + " pcs");
}
