Console.Write("Enter a number -> ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    
    int pow = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"{i}^3 = {pow}");
}