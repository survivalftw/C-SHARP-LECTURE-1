Console.WriteLine("Enter a Number");

int Number = int.Parse(Console.ReadLine());
int a = Number;
int Counter = 0;
int FirstDigit = 0;
int SecondDigit = 0;

while (a/10 != 0)
{
    FirstDigit = a/10;
    SecondDigit = a - (a/10) * 10;    
    a = a / 10;
    Counter = Counter + 1;
}

if (Counter > 1)
{
    int ThirdDigit = (Number - FirstDigit * Convert.ToInt32(Math.Pow(10, Counter)) - SecondDigit * Convert.ToInt32(Math.Pow(10, Counter-1)))/Convert.ToInt32(Math.Pow(10, Counter-2));
    if (Number > 0)
    {
        Console.WriteLine(ThirdDigit);
    }
    else
    {
        Console.WriteLine(-ThirdDigit);
    }
}
else
{
    Console.WriteLine("There is no ThirdDigit");
}
