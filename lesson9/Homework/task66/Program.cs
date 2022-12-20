int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    
    return SumNumbers(num1 + 1, num2) + num1;

}

System.Console.WriteLine(SumNumbers(4, 8));