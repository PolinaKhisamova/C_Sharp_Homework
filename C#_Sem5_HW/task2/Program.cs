// Задать одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.

int [] CreateArray()
{
    int size = new Random().Next(4,10);
    int[] randomArray = new int [size];
    for(int i = 0; i < size; i ++)
    {
        randomArray[i] = new Random().Next(-100,1000);
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

void SumOfElem (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Summ of elements on uneven positions is {sum}.");
}

int [] myArray = CreateArray();
PrintArray(myArray);
SumOfElem(myArray);