// Программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void Cube(int numberN)
{
    int current = 1;
    while(current<=numberN)
    {
        double result = Math.Pow(current, 3);
        Console.Write($"{result}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Enter a number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Cube(user_number);