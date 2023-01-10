Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());

double[,] array = GetArrayRandom(m,n);


GetArrayRandom(m, n);
PrintArray(array);

double[,] GetArrayRandom(int m, int n)
{
Random random = new Random();
double[,] array = new double [m,n];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            array[i,j] = random.Next(-999,999);
        }
    }
return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 1)
    {
        for (int j = 0; j < array.GetLength(1); j += 1)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}