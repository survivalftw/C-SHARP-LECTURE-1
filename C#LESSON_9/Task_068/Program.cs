Console.Write("Enter M:\t");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter N:\t");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(MethodAckerman(n,m));

int MethodAckerman (int a, int b)
{
    if (a == 0)
    return b + 1;

    if ((a > 0) && (b == 0))
    return MethodAckerman(a - 1, 1);

    if ((b > 0) && (a > 0))
    return MethodAckerman(a - 1, MethodAckerman(a, b - 1));
return MethodAckerman (a, b);
}
