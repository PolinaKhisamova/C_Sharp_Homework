int APowB (int num1, int num2)
{
    int res = 1;
    for(int i = 1; i <= Math.Abs(num2); i++)
    {
        res*=num1;
    }
    return res;
}

Console.Write("Input number A: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int num_b = Convert.ToInt32(Console.ReadLine());
int result = APowB(num_a, num_b);
Console.WriteLine($"{num_a} power abs. ({num_b}) equals {result}");