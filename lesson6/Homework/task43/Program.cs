Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Intersection(b1, k1, b2, k2);

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
    double y = Convert.ToDouble(k2 * x + b2);
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"The point of intersection of two straight lines is {x} and {y}");
}
