Console.WriteLine("Enter a number");

int a = int.Parse(Console.ReadLine());

int b = (a % 2) * (a % 2);

if(b == 0)
{
    Console.Write("Number = ");
    Console.WriteLine(a);
    Console.Write("is even");
}
if(b == 1)
{
    Console.Write("Number = ");
    Console.WriteLine(a);
    Console.Write("is odd");
}
