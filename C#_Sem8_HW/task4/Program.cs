// Сформировать трехмерный массив из неповторяющихся двузначных чисел.
// Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [] UniqueRandomNums (int size, int minVal, int maxVal)
{
    int [] randomNumsArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomNumsArray[i] = new Random().Next(minVal, maxVal+1);
        for (int j = i; j > 0; j--)
        {
            if (randomNumsArray[i] == randomNumsArray[j-1])
            {
                i--;
                break;
            }
        }
    }
    return randomNumsArray;
}

int [,,] Create3DArray (int rows, int colls, int lines)
{
    int [,,] array3D = new int [rows, colls, lines];
    int [] randomNums = UniqueRandomNums(rows*colls*lines, 10, 99);
    int randomNumIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colls; j++)
        {
            for (int k = 0; k < lines; k++)
            {
                array3D[i,j,k] = randomNums[randomNumIndex];
                randomNumIndex++;
            }
        }
    }
    return array3D;
}

void Print3DArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[j,k,i] + $"({j},{k},{i})    ");
            Console.WriteLine();
        }
    }
}

int [,,] myArray = Create3DArray (2, 2, 2);
Print3DArray (myArray);