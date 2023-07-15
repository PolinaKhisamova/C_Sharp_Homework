// Задать две матрицы. Написать программу, которая будет находить произведение двех матриц.

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

void Multiplication (int [,] matrixA, int [,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        int [,] multiMatrix = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                multiMatrix[i,j] = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    multiMatrix[i,j] += matrixA[i,k]*matrixB[k,j];
                }
                Console.Write(multiMatrix[i,j] + "  ");
            }
            Console.WriteLine();
        }
    }
    else
        Console.WriteLine("Impossible to multiply. Number of collumns in matrix A should be equal to number of rows in matrix B.");
}

int [,] myArray1 = Create2DArray();
int [,] myArray2 = Create2DArray();
Console.WriteLine("Matrix A:");
Print2DArray(myArray1);
Console.WriteLine("Matrix B:");
Print2DArray(myArray2);
Console.WriteLine("Matrix A by Matrix B equals:");
Multiplication(myArray1, myArray2);