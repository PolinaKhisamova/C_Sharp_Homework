// Задать двумерный массив из целых чисел. Найти среднее арифметическое элемнтов в каждом столбце.

void FindAvg (double [,] array2D)
{
    Console.Write("Avarage of each row is: ");
    for(int i = 0; i < array2D.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array2D.GetLength(0); j++)
        {
            sum += array2D[j,i];
        }
        double avg = Math.Round(sum/array2D.GetLength(0), 2);
        Console.Write(avg + ";  ");
    }
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

double [,] myArray = new double [,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
Print2DArray(myArray);
FindAvg(myArray);