// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

int [] CreateNumbers (int count)
{
    int [] createdNumbers = new int [count];
    for(int i = 0; i < count; i++)
    {
        createdNumbers[i] = new Random().Next(-9,10);
    }
    return createdNumbers;
}

void ShowNumbers (int [] numbers)
{
    Console.Write("Your numbers are: ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.WriteLine("\b\b. ");
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

Console.Write("Enter how many numbers you want to generate: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] yourNumbers = CreateNumbers(num);
ShowNumbers(yourNumbers);
NumberOfPosElem(yourNumbers);