// Программа, которая задает массив из производльного количества элементов и выводит их на экран.

int [] CreateNewArray(int random_size)
{
    int[] randomArray = new int [random_size];
    for(int i = 0; i < random_size; i ++)
    {
        randomArray[i] = new Random().Next(0,10);
    }
    return randomArray;
}

void PrintArray (int [] array_to_print)
{
    Console.Write("Your array is: ");
    for(int i = 0; i < array_to_print.Length; i ++)
        Console.Write(array_to_print[i] + " ");
}

Console.Write("Input max. array size: ");
int max_size = Convert.ToInt32(Console.ReadLine());
if(max_size > 0)
{
    int size = new Random().Next(0, max_size+1);
    int [] array = CreateNewArray(size);
    PrintArray(array);
}
else Console.WriteLine("Incorrect max. array size.");