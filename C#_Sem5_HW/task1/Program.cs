// Задать массив, заполненный случайными положительными трехзначными числами.
// Написать программу, которая покажет количество четных чисел в массиве.

int [] CreateArray()
{
    int size = new Random().Next(4,10);
    int[] randomArray = new int [size];
    for(int i = 0; i < size; i ++)
    {
        randomArray[i] = new Random().Next(100,1000);
    }
    return randomArray;
}

void PrintArray (int [] array)
{
    Console.Write("Your array is: ");
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void CountEvenElem (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            count++;
    }
    Console.WriteLine($"There are {count} even numbers in your array.");
}

int [] myArray = CreateArray();
PrintArray(myArray);
CountEvenElem(myArray);