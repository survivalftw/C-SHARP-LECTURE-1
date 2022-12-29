Console.WriteLine("Enter a Number");

int Number = int.Parse(Console.ReadLine());
int a = Number;
int b = 0;
int sum = 0;

while (a / 10 != 0)
{
    b = a % 10;
    sum = sum + b;
    a = a / 10;
}
sum = Math.Abs(sum + a);

Console.WriteLine("Number digit sum is " + sum);