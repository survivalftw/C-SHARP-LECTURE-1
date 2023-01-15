Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(m,n);
GetArrayRandom(m, n);
PrintArray(array);
Console.WriteLine();
int[,] result = CopyArray (array);
CreateArrayRowDescending(result);
PrintArray(result);

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

int[,] CopyArray(int[,] array)
{
int[,] result = new int [array.GetLength(0), array.GetLength(1)];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            result[i,j] = array[i,j];
        }
    }
return result;
}

void CreateArrayRowDescending(int[,] result)
{
    int a = 0;
    int memoryOne = 0;
    while (a < result.GetLength(1))
    {
        for (var i = 0; i < result.GetLength(0); i += 1)
        {
            for (var j = 0; j < result.GetLength(1) - 1; j += 1)
            {
                if (result[i,j+1] > result[i,j])
                {  
                    memoryOne = result[i,j];
                    result[i,j] = result[i,j+1];
                    result[i,j+1] = memoryOne;
                }
            }
        }
    a = a + 1;
    }  
}