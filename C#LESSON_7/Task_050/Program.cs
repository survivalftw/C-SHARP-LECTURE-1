Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter Array m position of element:\t");
int mSearch = int.Parse(Console.ReadLine());
Console.Write("Enter Array n position of element:\t");
int nSearch = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(m,n);

GetArrayRandom(m, n);
PrintArray(array);
FindNumberArray(array);

int[,] GetArrayRandom(int m, int n)
{
Random random = new Random();
int[,] array = new int [m,n];
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            array[i,j] = random.Next(1,9);
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

void FindNumberArray(int[,] array)
{
    if (mSearch < array.GetLength(0) && mSearch >= 0 && nSearch < array.GetLength(1) && nSearch >= 0)
        {
            Console.Write("Selected element is ");
            Console.Write(array[mSearch,nSearch]);
        }
    else
    {
            Console.WriteLine("There is no such an element: selected index was outside the bounds of the array");
    };
}