const int SIZE = 6;

int[] array = new int[SIZE];

RandomizeArray(array);
PrintArray(array);
(int max, int min) = GetSubstractionMaxAndMin(array);
System.Console.WriteLine($"max = {max}, min = {min}. Substraction = {max - min}");

int[] RandomizeArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 101);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine($"[{string.Join(", ", arr)}]");
}

(int, int) GetSubstractionMaxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}