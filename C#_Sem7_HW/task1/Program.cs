// Задать двумерный массив размером m*n, заполненный случайными вещественными числами.

double [,] Create2DArray()
{
    Console.Write("How many rows? - ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("How many collumns? - ");
    int colls = Convert.ToInt32(Console.ReadLine());
    double [,] created2DArray = new double[rows, colls];
    for (int i = 0; i < created2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < created2DArray.GetLength(1); j++)
            created2DArray [i,j] = Math.Round(new Random().Next(1,10) + new Random().NextDouble(), 2);
    }
    return created2DArray;
}

void Print2DArray(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i,j] + ",  ");
        Console.WriteLine();
    }
}

double [,] myArray = Create2DArray();
Print2DArray(myArray);