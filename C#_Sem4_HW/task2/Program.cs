// Программа, которая принимает на вход число и выдает сумму цифр в числе.

int SumOfDigits(int num)
{
    int sum = 0;
    while(num/10 != 0)
    {
        sum += Math.Abs(num%10);
        num /= 10;
    }
    sum += Math.Abs(num);
    return sum;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(number);
Console.WriteLine($"Sum of digits of {number} is {result}");