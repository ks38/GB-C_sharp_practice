const int SIZE = 25;
int[] arr = new int[SIZE];
RandomizeArray(arr);
PrintArray(arr);
SummCount(arr);

void RandomizeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine($"[{string.Join(", ", arr)}]");
}

void SummCount(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            sum += arr[i];
        }
    }
    System.Console.WriteLine("Summ of elements: " + sum);
}

