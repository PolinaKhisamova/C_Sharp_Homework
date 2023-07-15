// Задать двумерный массив. Написать программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [,] SortArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < (array2D.GetLength(1)-1); j++)
        {
            int maxPos = j;
            for (int k = j+1; k < array2D.GetLength(1); k++)
            {
                if(array2D[i,k] > array2D[i,maxPos])
                    maxPos = k;
            }
            int temp = array2D[i,j];
            array2D[i,j] = array2D[i,maxPos];
            array2D[i,maxPos] = temp;
        }
    }
    return array2D;
}

int [,] myArray = Create2DArray();
Print2DArray(myArray);
int [,] sortedArray = SortArray(myArray);
Print2DArray(sortedArray);