//Программа, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Enter a 3-digital number: ");
int num = Convert.ToInt32(Console.ReadLine());
void getDigit2(int arg)
{
    if(arg < 0) arg = arg*(-1);
    if(arg>99 && arg<1000)
    {
        Console.WriteLine("The second digit is " + arg/10%10);
    }
    else
    {
        Console.WriteLine("Entered number is NOT a 3-digital");
    }
}
getDigit2(num);