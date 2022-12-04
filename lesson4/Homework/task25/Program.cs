int enterNumbers()
{
    System.Console.Write("Enter number: ");
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}

int aDegreeB(int A, int B)
{
    int degree = 1;
    for (int i = 1; i <= B; i++)
    {
        degree *= A;
    }
    return degree;
}

int result = aDegreeB(enterNumbers(),enterNumbers());
System.Console.WriteLine("степень числа = " + result);