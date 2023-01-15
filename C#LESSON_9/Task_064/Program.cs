Console.Write("Enter N:\t");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    MyMethod(n);
    void MyMethod(int i)
    {
    if (i == 0)
    {
        return;
    }
    Console.WriteLine(i);
    i -= 1;
    MyMethod(i);
    }
}
else
{
    Console.WriteLine("N is <= 0");
}