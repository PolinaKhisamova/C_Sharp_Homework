//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
void getDigit3(int arg)
{
    if(arg < 0) arg = arg*(-1);
    if(arg>99)
    {
        while(arg/10 > 99)
        {
            arg = arg/10;
        }
        Console.WriteLine("The third digit is " + arg%10);
    }
    else
    {
        Console.WriteLine("There is NO third digit");
    }
}
getDigit3(num);