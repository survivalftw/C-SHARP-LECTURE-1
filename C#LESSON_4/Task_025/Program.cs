Console.WriteLine("Enter base A");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Enter power B");

int B = int.Parse(Console.ReadLine());

int Pow = GetExponentiationBaseAPowerB(A, B);

if (B>=0)
{
    Console.WriteLine(Pow);
}
else
{
    Console.WriteLine("1/" + Pow);
}

int GetExponentiationBaseAPowerB(int A, int B)
{
    int Pow = 1;
    for (var i = 1; i <= Math.Abs(B); i++)
    {
        Pow = Pow * A;
    }

    return Pow;
}