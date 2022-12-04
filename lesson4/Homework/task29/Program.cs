int[] array = new int[arrayLength()];
fillArray(array);
printArray(array);

void fillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Enter {i + 1} massive element: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArray(int[] arr)
{
    System.Console.Write($"[{string.Join(", ", arr)}]");
}

int arrayLength() {
    System.Console.Write("Enter massive length: ");
   int num = Convert.ToInt32(Console.ReadLine());
    return num;
}