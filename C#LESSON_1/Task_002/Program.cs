Console.WriteLine("Enter a and b");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
if(a == b)
{
    Console.Write("max = min = ");
    Console.WriteLine(a);
}
if(a < b)
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}