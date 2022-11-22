// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
Console.Write("Enter first number -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number -> ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 > num2 ? "Первое число больше \nmax = " + num1 + ", " + "min = " + num2 
    :"Второе число больше \nmax  = " + num2 + ", " + "min = " + num1);
