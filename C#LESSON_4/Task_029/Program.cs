Console.WriteLine("Enter Array size up to 8");
int size = int.Parse(Console.ReadLine());

Console.Write("Enter " + size);
Console.Write(" Array elements and press enter " + (8-size));
Console.Write(" times ");

string A = Console.ReadLine();
string B = Console.ReadLine();
string C = Console.ReadLine();
string D = Console.ReadLine();
string E = Console.ReadLine();
string F = Console.ReadLine();
string G = Console.ReadLine();
string H = Console.ReadLine();

string[] ArrayText = new string[] {A,B,C,D,E,F,G,H};

string[] result = CreateArray();
PrintArray(result);

string[] CreateArray()
{
    string[] array = new string [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = ArrayText[i];
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