// Программа, которая заполнит спирально массив 4 на 4.

int [,] Fill2DArray (int rows, int colls, int initValue)
{
    int [,] array = new int [rows, colls];
    array[0,0] = initValue - 1;
    for (int k = 0; k < rows; k++)
    {
        int i = 0 + k;
        for (int m = k; m < colls-k; m++)
        {
            if (i == 0 && m == 0)
                array[i,m] = 1;
            else
                array[i,m] = array[i,m-1] + 1;
        }
        int j = colls - 1 - k;
        for (int n = 1 + k; n < rows - k; n++)
        {
            array[n,j] = array[n-1,j] + 1;
        }
        i = rows - 1 - k;
        for (int m = colls-2-k; m >= k; m--)
        {
            array[i,m] = array[i,m+1] +1;
        }
        j = k;
        for (int n = rows-2-k; n >= 1+k; n--)
        {
            array[n,j] = array[n+1,j] + 1;
        }
    }
    return array;
}

void Print2DArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i,j] < 10 && array2D[i,j] > -10)
                Console.Write("0" + array2D[i,j] + "    ");
            else
                Console.Write(array2D[i,j] + "    ");
        }
        Console.WriteLine();
    }
}

int [,] myArray = Fill2DArray (4, 4, 1);
Print2DArray(myArray);