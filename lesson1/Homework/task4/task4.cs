// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Enter first digit -> ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second digit -> ");
int second = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter third digit -> ");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;

if (second > max && second > third) max = second;
else if (third > max && second < third) max = third;

Console.WriteLine("max = " + max);