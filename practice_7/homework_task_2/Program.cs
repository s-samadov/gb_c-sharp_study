Console.Clear();
Console.Write("Enter position X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter position Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray()
{
    int r = new Random().Next(2, 5);
    int c = new Random().Next(2, 5);
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] matr)
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

int[,] array = CreateArray();
PrintArray(array);

int FindArrayPosition(int x, int y, int[,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (x == i && y == j)
            {
                result = array[i, j];
            }    
        }
    }
    return result;
}

int test = FindArrayPosition(x, y, array);
if (test > 0)
{
    Console.WriteLine($"Coordinate value is: {test}");
}
else 
{
    Console.WriteLine("There is no such coordinate in the array");
}




//FindArrayPosition(x, y, array);

