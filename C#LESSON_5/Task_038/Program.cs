Console.WriteLine("Enter Array size");
int size = int.Parse(Console.ReadLine());

double[] result = CreateArray();
PrintArray(result);
FindMaxMinDiffNumberArray(result);

double[] CreateArray()
{  
    Random random = new Random();
    double[] array = new double [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-999,999);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

void FindMaxMinDiffNumberArray(double[] array)
{
    double MaxNumber = array [0];
    double MinNumber = array [0];
    for (var i = 0; i < array.Length; i += 1)
        {
            if (MaxNumber < array[i])
            {
                MaxNumber = array[i];
            }
            if (MinNumber > array[i])
            {
                MinNumber = array[i];
            }        
        }
    Console.WriteLine(" ");
    Console.Write("Difference between min and max numbers is " + (MaxNumber - MinNumber));
}