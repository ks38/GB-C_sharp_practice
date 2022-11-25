class HomeWork2
{
    static void Main()
    {
        Console.Write("Enter number for task10 -> ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Task10(number));

        Console.Write("Enter number for task13 -> ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Task13(number2));

        Console.Write("Enter number of day of week for task10 -> ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Task15(number3));
    }

    static int Task10(int num)
    {
        int rezult = -1;
        if (num < 999 && num > 100)
        {
            rezult = (num / 10) % 10;
        }
        return rezult;
    }

    static int Task13(int num)
    {
        if (num < 100 && num > -100) return -1;
        else
        {
            while (!(num / 1000 == 0))
            {
                num /= 10;
            }
            num %= 10;
        }
        return (num >= 0 ? num : -num);
    }

    static bool Task15(int day)
    {
        if (day == 6 || day == 7) return true;
        return false;
    }

}
