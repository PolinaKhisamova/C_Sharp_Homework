// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

void ShowEnteredNumbers (int [] numbers)
{
    Console.Write("You have entered: ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("\b\b. ");
}

void NumberOfPosElem (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    Console.WriteLine($"There are {count} positive numbers.");
}

Console.Write("Enter 5 numbers. Number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 4: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 5: ");
int num5 = Convert.ToInt32(Console.ReadLine());
int [] enteredNumbers = {num1, num2, num3, num4, num5};

ShowEnteredNumbers(enteredNumbers);
NumberOfPosElem(enteredNumbers);


