Console.Write("Enter Array size:\t");
int size = int.Parse(Console.ReadLine());

int[] myArray =  new int[size];
for (int i = 0; i < myArray.Length; i += 1)
{
    Console.Write($"Enter Array element with index {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}

PrintArray(myArray);
FindPositiveNumberCountArray(myArray);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i += 1)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

void FindPositiveNumberCountArray(int[] array)
{
    int positiveNumberCount = 0;
    for (var i = 0; i < array.Length; i += 1)
        {
            if (array[i] > 0)
            {
                positiveNumberCount += 1;
            }       
        }
    Console.WriteLine(" ");
    Console.Write("There is " + positiveNumberCount);
    Console.Write(" positive element(s) in Array");
}