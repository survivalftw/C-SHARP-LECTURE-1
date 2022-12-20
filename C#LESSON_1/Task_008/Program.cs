Console.WriteLine("Enter N");

int N = int.Parse(Console.ReadLine());
int number = 1;
if (N > 0)
{
    while (number <= N)
    {
    int evencheck = number % 2;
    if (evencheck == 0)
    {
        Console.Write(number);
        Console.Write(" ");         
    }
    number++;
    }
}
else
{
    while (N <= number)
    {
    int evencheck = number % 2;
    if (evencheck == 0)
    {
        Console.Write(number);
        Console.Write(" ");         
    }
    number--;
    }
}