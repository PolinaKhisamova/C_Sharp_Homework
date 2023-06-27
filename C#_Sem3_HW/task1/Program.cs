// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void Palindrome(int arg)
{
    if(arg>=10000 && arg<=99999)
    {
        if(arg/10000 == arg%10 && arg/1000%10 == arg%100/10)
        {
            Console.WriteLine($"Entered number {arg} is a palindrome");
        }
        else
        {
            Console.WriteLine($"Entered number {arg} is NOT a palindrome");
        }
    }
    else
    {
        Console.WriteLine($"Your number {arg} is NOT a 5-digital. Try again");
    }
}

Console.Write("Enter a 5-digital number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0)
{
    Palindrome(number);
}
else
{
    number = number*(-1);
    Palindrome(number);
}