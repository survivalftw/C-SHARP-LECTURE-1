Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(m,n);
int[,] arrayTwo = GetArrayRandom(m,n);
int[,] result = ArrayMaxtrixMultiplication (array);

GetArrayRandom(m, n);
PrintArray(array);
Console.WriteLine();
PrintArray(arrayTwo);
Console.WriteLine();
PrintArray(result);


int[,] GetArrayRandom(int m, int n)
{
Random random = new Random();
int[,] array = new int [m,n];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            array[i,j] = random.Next(0,9);
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

int[,] ArrayMaxtrixMultiplication(int[,] array)
{
int[,] result = new int [array.GetLength(0), array.GetLength(1)];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            var k = 0;
            while (k < array.GetLength(0))
            {
                result[i,j] = result[i,j] + array[i,k] * arrayTwo[k,j];
                k = k + 1;
            }  
        }
    }
return result;
}