Console.WriteLine("Enter a number");

int N = int.Parse(Console.ReadLine());

int a = N / 100;

int b = N - a * 100;
int c = b / 10;
if (N > 0)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine(-c);
}