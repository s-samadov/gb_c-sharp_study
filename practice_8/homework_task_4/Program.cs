Console.Clear();
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of heights: ");
int heights = Convert.ToInt32(Console.ReadLine());


int[,,] CreateArray(int r, int c, int h)
{
    int[,,] result = new int[r, c, h];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int k = 0; k < h; k++)
            {
                result[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();        
        }
    }
}

int[,,] array = CreateArray(rows, columns, heights);
PrintArray(array);