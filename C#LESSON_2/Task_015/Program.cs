Console.WriteLine("Enter a Number");

int Weekend = int.Parse(Console.ReadLine());

if (Weekend < 8 && Weekend > 0)
{
    if (Weekend == 6 || Weekend == 7)
    {
    Console.WriteLine("Holyday");
    }
    else
    {
    Console.WriteLine("Weekday");
    }
}
else
{
    Console.WriteLine("Error");
}