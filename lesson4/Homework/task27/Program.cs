printSum(summOfNumbers(enterNumber()));

int enterNumber()
{
    System.Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int summOfNumbers(int num)
{
    if (num < 0) num *= -1;
    int sum = 0;
    while (num != 0)
    {
        int temp = 0;
        sum += num % 10 + temp;
        num /= 10;
    }
    return sum;
}

void printSum(int sum)
{
System.Console.Write("сумма цифр введенного чиcла = " + sum);
}
