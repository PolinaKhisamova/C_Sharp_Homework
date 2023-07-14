double [,] Create2DArray()
{
    Console.Write("How many rows? - ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("How many collumns? - ");
    int colls = Convert.ToInt32(Console.ReadLine());
    double [,] created2DArray = new double[rows, colls];
    for (int i = 0; i < created2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < created2DArray.GetLength(1); j++)
            created2DArray [i,j] = Math.Round(new Random().Next(1,10) + new Random().NextDouble(), 2);
    }
    return created2DArray;
}

void Print2DArray(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i,j] + ",  ");
        Console.WriteLine();
    }
}

void FindElem (double [,] array2D)
{
    Console.Write("Which row? - ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Which collumn? - ");
    int coll = Convert.ToInt32(Console.ReadLine());
    if(row <= array2D.GetLength(0) && coll <= array2D.GetLength(1))
        Console.Write($"The element in row {row} and collumn {coll} is {array2D[row-1,coll-1]}");
    else
        Console.Write("Wrong position.");
}

double [,] myArray = Create2DArray();
Print2DArray(myArray);
FindElem(myArray);