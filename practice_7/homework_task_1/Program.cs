Console.Clear();
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] CreateArray(int r, int c)
{
    double[,] result = new double[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = Math.Round((new Random().NextDouble() * 200 - 100), 3);
        }
    }
    return result;
}

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateArray(rows, columns);
PrintArray(array);
