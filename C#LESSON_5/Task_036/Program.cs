Console.WriteLine("Enter Array size");
int size = int.Parse(Console.ReadLine());
int Count = 0;

int[] result = CreateArray();

PrintArray(result);
CountOddIndexSumArray(result);

int[] CreateArray()
{  
    Random random = new Random();
    int[] array = new int [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-999,999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

void CountOddIndexSumArray(int[] array)
{
    for (var i = 1; i < array.Length; i += 2)
        {
            Count = Count + array[i];
        }
    Console.WriteLine(" ");
    Console.Write("Odd index numbers sum is " + Count);
}
