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

void TestArray(int[,] array)
{   
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i, j];
            }
        //Console.WriteLine();
        }
    }
    Console.Write($"Sum of all elements: {result}");
}
TestArray(array);
//Show2LayerArray(array);

