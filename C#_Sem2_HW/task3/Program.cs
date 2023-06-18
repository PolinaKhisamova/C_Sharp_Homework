//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Enter a weekday number: ");
int daynum = Convert.ToInt32(Console.ReadLine());
void getWeekend(int arg)
{
    if(arg>0 && arg<8)
    {
        if(arg == 6 || arg == 7)
        {
            Console.WriteLine("It's a weekend!");
        }
        else
        {
            Console.WriteLine("It's NOT a weekend");
        }
    }
    else
    {
        Console.WriteLine("NOT a weekday number. Enter a number between 1 and 7");
    }
}
getWeekend(daynum);