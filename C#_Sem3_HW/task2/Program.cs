// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double LongLineAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
    return Math.Round(longLine, 2);
}

Console.Write("Enter X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z coord of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Z coord of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());
double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance between A ({xCoordA}, {yCoordA}, {zCoordA}) and B ({xCoordB}, {yCoordB}, {zCoordB}) is {dist}.");