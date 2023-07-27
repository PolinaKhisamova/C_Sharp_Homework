// Задать числи M и N. Написать программу, которая найдет сумму натуральных элементов от M до N.

void SumOfElements (int m, int n, ref int s)
{
    if (n != m) SumOfElements(Math.Min(m,n), Math.Max(m,n)-1, ref s);
    s += Math.Max(m, n);
}

int Sum (int m, int n)
{
    int sum = 0;
    SumOfElements(m, n, ref sum);
    return sum;
}

int res = Sum(4, 6);
Console.Write ("Summ of elements is " + res);