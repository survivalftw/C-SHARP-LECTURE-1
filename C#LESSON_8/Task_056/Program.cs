Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(m,n);

GetArrayRandom(m, n);
PrintArray(array);
Console.WriteLine();
FindArrayRowSumMinimum(array);

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


void FindArrayRowSumMinimum(int[,] array)
{
    int memoryMinSum = 0;
    int rowNubmer = 1;
    for (var i = 0; i < 1; i += 1)
    {
        int count = 0;
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            count = count + array[i,j];
        }
        memoryMinSum = count;
    }
    for (var i = 1; i < array.GetLength(0); i += 1)
    {
        int count = 0;
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            count = count + array[i,j];
        }
            if (count < memoryMinSum)
            {
                memoryMinSum = count;
                rowNubmer = i + 1;
            }
    }
    Console.Write("The least row sum is "+ memoryMinSum);
    Console.Write(", row number "+ rowNubmer);
}