// Написать метод для разворота массива, не используя память под дополнительный массив


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 101);
    }
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}


void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - (i + 1)];
        arr[arr.Length - (i + 1)] = temp;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ReverseArray(array);
Console.WriteLine();
PrintArray(array);

