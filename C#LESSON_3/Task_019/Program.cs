Console.WriteLine("Enter a Number");

int Number = int.Parse(Console.ReadLine());
int FirstDigit = Math.Abs(Number) / 10000;
int SecondDigit = Math.Abs(Number) / 1000 - FirstDigit * 10;
int ThirdDigit = Math.Abs(Number) / 100 - FirstDigit * 100 - SecondDigit * 10;
int FourthDigit = Math.Abs(Number) / 10 - FirstDigit * 1000 - SecondDigit * 100 - ThirdDigit * 10;
int FifthDigit = Math.Abs(Number) - FirstDigit * 10000 - SecondDigit * 1000 - ThirdDigit * 100 - FourthDigit * 10;

if (Number / 10000 == 0 || Number / 100000 != 0)
{
    Console.WriteLine("Enter a five-digit number");
}
else
{
    if (FirstDigit == FifthDigit && SecondDigit == FourthDigit)
    {
        Console.WriteLine("Number is palindrome");
    }
    else
    {
        Console.WriteLine("Number is not palindrome");
    }
}
