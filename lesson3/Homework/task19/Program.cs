Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int n = num;


bool isPalindrome(int num)
{
    while (n > 0)
    {
        int lastNum = n % 10;
        reverse = reverse * 10 + lastNum;
        n = n / 10;

    }
    return (num == reverse);
}

Console.Write(isPalindrome(num) ? "Number is palyndrome" : "Number isn't palyndrome");