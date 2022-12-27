int ReadNumber(string text) {
Console.WriteLine(text);
int number;
string readNumber = Console.ReadLine() ?? "Nullable";
if (int.TryParse(readNumber, out number)) {}
else
{
    Console.WriteLine("Enter digits only");
    number = ReadNumber (text);
}
return number;
}


int [] coordinateA = new int [3];
coordinateA = ReadCoordinate("Enter coordinate A");
int [] coordinateB = new int [3];
coordinateB = ReadCoordinate("Enter coordinate B");

Console.WriteLine("Distance between A and B = " + GetLengh(coordinateA, coordinateB));

int [] ReadCoordinate(string text) {
    Console.WriteLine(text);
    int [] number = new int [3];

    int x = ReadNumber("Enter x coordinate");
    int y = ReadNumber("Enter y coordinate");
    int z = ReadNumber("Enter z coordinate");
    number [0] = x;
    number [1] = y;
    number [2] = z;

    return number;
}

double GetLengh(int[] a, int[] b) {
    int lengthX = Math.Abs(a[0] - b[0]);
    int lengthY = Math.Abs(a[1] - b[1]);
    int lengthZ = Math.Abs(a[2] - b[2]);

    double lenghtTASK = Math.Sqrt(lengthX * lengthX + lengthY * lengthY + lengthZ * lengthZ);

    return lenghtTASK;
}