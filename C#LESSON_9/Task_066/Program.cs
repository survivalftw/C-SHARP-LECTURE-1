Console.Write("Enter M:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter N:\t");
int n = int.Parse(Console.ReadLine());
int sum = 0;

if (n > 0 && m > 0)
{
if (n > m)
{
    MyMethod(n);
    void MyMethod(int i)
    {
    if (i == m - 1)
    {
        return;
    }
    sum = sum + i;
    i -= 1;
    MyMethod(i);
    }
Console.WriteLine("Natural numbers sum between M and N is " + sum);
}
else
{
    MyMethod(m);
    void MyMethod(int i)
    {
    if (i == n - 1)
    {
        return;
    }
    sum = sum + i;
    i -= 1;
    MyMethod(i);
    }
Console.WriteLine("Natural numbers sum between M and N is " + sum);
}
}
else
{
    Console.WriteLine("N or M <= 0");
}