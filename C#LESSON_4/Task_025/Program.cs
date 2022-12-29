Console.WriteLine("Enter base A");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Enter power B");

int B = int.Parse(Console.ReadLine());

int Pow = GetExponentiationBaseAPowerB(A, B);

Console.WriteLine(Pow);

int GetExponentiationBaseAPowerB(int A, int B)
{
    int Pow = 1;
    for (var i = 1; i <= B; i++)
    {
        Pow = Pow * A;
    }

    return Pow;
}