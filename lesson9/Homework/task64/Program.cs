uint NumbersDown(uint num)
{
    if (num == 1) return 1;
    Console.Write(num + " ");
    return NumbersDown(num - 1);
}

System.Console.WriteLine(NumbersDown(19));
