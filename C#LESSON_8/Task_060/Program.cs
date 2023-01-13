Console.Write("Enter Array m dimension size:\t");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter Array n dimension size:\t");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter Array o dimension size:\t");
int o = int.Parse(Console.ReadLine());

int[,,] array = GetArrayRandom(m,n,o);

bool Containts(int[,,] array, int number)
{
    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            for (var k = 0; k < array.GetLength(2); k += 1)
            {
                {
                    if (array [i,j,k] == number)
                    {
                        return true;
                    }
                }
            }
        }
    }
return false;
}

int[,,] GetArrayRandom(int m, int n, int o)
{
int memoryForTesting = 0;
int indexI = 0;
int indexJ = 0;
int indexK = 0;
Random rand = new Random();
int[,,] array = new int [m,n,o];

    for (var i = 0; i < array.GetLength(0); i += 1)
    {
        for (var j = 0; j < array.GetLength(1); j += 1)
        {
            for (var k = 0; k < array.GetLength(2); k += 1)
            {
                {
                    int number;
                    do
                    {
                        number = rand.Next(10,99);
                    } while (Containts(array, number));

                    array [i,j,k] = number;

                    indexI = i;
                    indexJ = j;
                    indexK = k;
                    Console.Write(array [i,j,k]);
                    Console.Write(" (" + indexI);
                    Console.Write(", " + indexJ);
                    Console.Write(", " + indexK);
                    Console.Write(")");
                    Console.WriteLine();
                }
            }
        }
    }
return array;
}