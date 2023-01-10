Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(m,n);

GetArrayRandom(m, n);
PrintArray(array);
Console.WriteLine("Arithmetic mean values are located below each corresponding column");
FindArrayColumnArithmeticMean(array);

int[,] GetArrayRandom(int m, int n)
{
Random random = new Random();
int[,] array = new int [m,n];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            array[i,j] = random.Next(0,99);
        }
    }
return array;
}

void PrintArray(int[,] array)
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

void FindArrayColumnArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j += 1)
    {
        double counterCount = 0;
        for (int i = 0; i < array.GetLength(0); i += 1)
        {
            counterCount = counterCount + array[i,j];
        }
        double columnMean = counterCount / array.GetLength(1);
        Console.Write(columnMean);
        Console.Write("; ");
    }
}