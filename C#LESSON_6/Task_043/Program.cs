Console.Write("Enter k1 variable:\t");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Enter b1 variable:\t");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Enter k2 variable:\t");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Enter b2 variable:\t");
double b2 = double.Parse(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = (b2 - b1)/(k1 - k2) * k1 + b1;

if (k1 == k2)
{
    Console.WriteLine("Two strait lines are paralleled");
}
else
{
    Console.Write("Cross coordinates are (" + x);
    Console.Write("; " + y);
    Console.Write(")");
}
