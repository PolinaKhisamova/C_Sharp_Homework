// Задать число N. Написать программу, которая выводит все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

void ShowNums (int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n-1);
}

Console.Write("Enter your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
ShowNums(userNumber);