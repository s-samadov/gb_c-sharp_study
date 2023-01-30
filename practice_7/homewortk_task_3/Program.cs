Console.Clear();
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] Creat2LayerArray(int r, int c)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void Show2LayerArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = Creat2LayerArray(rows, columns);
Show2LayerArray(array);

void TestArray(int[,] array, int r)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[j, i];
        }
        result = result / r;
        Console.WriteLine($"Columns:{i} Average value:{Math.Round(result,3)}; ");
        //Console.WriteLine();
    }
}
TestArray(array, rows);
//Show2LayerArray(array);

