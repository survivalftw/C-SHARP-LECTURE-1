Console.WriteLine("Enter a Number");

int Number = int.Parse(Console.ReadLine());
int a = 1;
int Cubed = 0;

if (Number < 0)
{
        while (Number < a)
    {
        Cubed = Convert.ToInt32(Math.Pow(a, 3));
        Console.Write(Cubed + ", ");
        a = a - 1;
    }
    if (Number == a)
    {
        Cubed = Convert.ToInt32(Math.Pow(a, 3));
        Console.Write(Cubed);
    }
}
else
{
    while (Math.Abs(Number) > a)
    {
        Cubed = Convert.ToInt32(Math.Pow(a, 3));
        Console.Write(Cubed + ", ");
        a = a + 1;
    }
    if (Math.Abs(Number) == a)
    {
        Cubed = Convert.ToInt32(Math.Pow(a, 3));
        Console.Write(Cubed);
    }
}