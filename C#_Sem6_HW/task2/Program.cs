// Программа, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2, k2 задаются пользователем.
// x = (b2 - b1) / (k1 - k2); y = k1 * x + b1

void Junction (int k1, int b1, int k2, int b2)
{
    int [] point = new int [2];
    if(k1 != k2)
    {
        point[0] = (b2 - b1) / (k1 - k2);
        point[1] = k1 * point[0] + b1;
        Console.Write($"Array 'y = {k1}*x + {b1}' crosses array 'y = {k2}*x + {b2}' in point A ({point[0]}, {point[1]}).");
    }
    else
        Console.Write($"Arrays 'y = {k1}*x + {b1}' and 'y = {k2}*x + {b2}' don't cross.");
}

Console.Write("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Junction(k1, b1, k2, b2);