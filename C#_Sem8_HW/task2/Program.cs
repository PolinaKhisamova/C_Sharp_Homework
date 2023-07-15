// Задать прямоугольный двумерный массив. Написать программу, которая будет находить строку с наименььшей суммой элементов.

int [,] Create2DArray()
{
    Console.Write("How many rows? - ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("How many collumns? - ");
    int colls = Convert.ToInt32(Console.ReadLine());
    int [,] created2DArray = new int[rows, colls];
    for (int i = 0; i < created2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < created2DArray.GetLength(1); j++)
            created2DArray [i,j] = new Random().Next(1,10);
    }
    return created2DArray;
}

void Print2DArray(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i,j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindRow (int [,] array)
{
    int minSumRow = 0;
    int minSumOfElem = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minSumOfElem += array[0,j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumOfElem = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElem += array[i,j];
        }
        if (sumOfElem < minSumOfElem)
        {
            minSumOfElem = sumOfElem;
            minSumRow = i;
        }
    }
    Console.WriteLine("The row with the minimum summ of elements is " + (minSumRow + 1));
}

int [,] myArray = Create2DArray();
Print2DArray(myArray);
FindRow(myArray);