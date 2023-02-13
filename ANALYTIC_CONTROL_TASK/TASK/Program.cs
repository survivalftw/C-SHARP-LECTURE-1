int size = 8;
Console.Write("Enter " + size);
Console.Write(" string array elements and press Enter:\n");

string A = Console.ReadLine();
string B = Console.ReadLine();
string C = Console.ReadLine();
string D = Console.ReadLine();
string E = Console.ReadLine();
string F = Console.ReadLine();
string G = Console.ReadLine();
string H = Console.ReadLine();

string[] InitialArray = new string[] {A,B,C,D,E,F,G,H};

string[] result = CreateArray();
PrintArray(result);

string[] CreateArray()
{
    string[] array = new string [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = InitialArray[i];
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

/*
string[] CreateArrayLessThanThreeSymbols()
{
    string[] array = new string [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = InitialArray[i];
    }
    return array;
}
*/
