Console.WriteLine("Enter Array size");
int size = int.Parse(Console.ReadLine());
int Count = 0;

int[] result = CreateArray();

PrintArray(result);
CountEvenArray(result);

int[] CreateArray()
{  
    Random random = new Random();
    int[] array = new int [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,999);
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

void CountEvenArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Count = Count + 1;
        }
    }
    Console.WriteLine(" ");
    Console.Write("There are " + Count);
    Console.Write(" even numbers in array");
}
