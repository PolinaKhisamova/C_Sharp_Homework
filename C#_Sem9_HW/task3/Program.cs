// Функция Аккермана

int AckFunc (int n, int m)
{
    if (n == 0) return m+1;
    else if (m == 0) return AckFunc(n-1, 1);
    else return AckFunc(n-1, AckFunc(n, m-1));
}

int res = AckFunc(3,3);
Console.Write(res);