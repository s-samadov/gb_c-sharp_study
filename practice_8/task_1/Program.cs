﻿Console.Clear();
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

int[,] array = CreateArray(rows, columns);
PrintArray(array);

void NewArray(int[,] matr, int r)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[r - 1, i];
        array[r - 1, i] = array[0, i];
        array[0, i] = tmp;
    }
}
//   if(m!=n)
Console.WriteLine();
NewArray(array, rows);
PrintArray(array);



