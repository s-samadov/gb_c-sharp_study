Console.Clear();
Console.Write("Enter the number of rows of the first array: ");
int rowsA= Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of colomns of the first array: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of rows of the second array: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of colomns of the second array: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int r, int c)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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

int[,] array1 = CreateArray(rowsA, columnsA);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = CreateArray(rowsB, columnsB);
PrintArray(array2);


int [,] MultiplArray(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}
int[,] array3 = MultiplArray(array1, array2);
Console.WriteLine();
PrintArray(array3);
