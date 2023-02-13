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

string[] basearray = CreateArray();
int[] countresultarray = CreateUnitCountArray();
string[] resultarray = CreateZeroArray();
Console.Write("\n");
Console.Write("Initial Array:\t");
PrintStringArray(basearray);
Console.Write("\n");
PrintIntArray(countresultarray);
Console.Write("\n");
PrintStringArray(resultarray);

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

string[] CreateArray()
{
    string[] array = new string [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = InitialArray[i];
    }
    return array;
}

int[] CreateUnitCountArray()
{
    int[] array = new int [size];  
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = InitialArray[i].Length;
    }
    return array;
}

/*
string[] CreateResultArray()
{
    string[] array = InitialArray;
    int index = 2;    
    for (var i = index; i < array.Length - 1; i++)    
    {
        array[i] = array[i + 1];
    }
    Array.Resize(ref array, array.Length - 1);
    return array;
}


string[] CreateResultArray()
{
    string[] zeroarray = {0};
    string[] array = InitialArray;  
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3)
        {
            
        }
    }
    return array; 
}
*/

static void Insert(ref string[] array, string value, int index)
{
    string[] newArray = new string [array.Length + 1];
    newArray[index] = value;
    for (int i = 0; i < index; i++)
        newArray[i] = array[i];
    for (int i = index; i < array.Length; i++)
        newArray[i + 1] = array[i];
    array = newArray;
}

string[] CreateZeroArray()
{
    string[] array = {InitialArray[0]};
    int index = 1;
    string[] temparray = InitialArray;
    for (int i = 0; i < temparray.Length; i++)
    {
        if (temparray[i].Length < 4)
        {
            Insert(ref array, temparray[i], index);
            index = index + 1;
        }            
    }
    int zeroindex = 0;    
    for (var i = zeroindex; i < array.Length - 1; i++)    
    {
        array[i] = array[i + 1];
    }
    Array.Resize(ref array, array.Length - 1);
    return array;
}
