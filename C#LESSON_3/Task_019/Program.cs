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