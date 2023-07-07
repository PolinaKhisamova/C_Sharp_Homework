// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементами массива.

double [] CreateArray()
{
    int size = new Random().Next(4,10);
    double[] randomArray = new double [size];
    for(int i = 0; i < size; i ++)
    {
        randomArray[i] = Math.Round(new Random().Next(-10,10) + new Random().NextDouble(),2);
    }
    return randomArray;
}

void PrintArray (double [] array)
{
    Console.Write("Your array is: ");
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

double FindMaxElem (double [] array)
{
    double maxElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxElem)
            maxElem = array[i];
    }
    return maxElem;
}

double FindMinElem (double [] array)
{
    double minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minElem)
            minElem = array[i];
    }
    return minElem;
}

double [] myArray = CreateArray();
PrintArray(myArray);
Console.WriteLine($"The difference between the maximum and the minimum elements of your array is {Math.Round(FindMaxElem(myArray) - FindMinElem(myArray), 2)}.");