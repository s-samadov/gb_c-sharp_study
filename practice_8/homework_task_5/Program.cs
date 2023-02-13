Console.Clear();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[size, size];
int startPoint = 1;
int i = 0;
int j = 0; 

while (startPoint <= size * size)
{
    array[i, j] = startPoint;
    if (i <= j + 1 && i + j < size - 1) ++j;
    else if (i < j && i + j >= size - 1) ++i;
    else if (i >= j && i + j > size - 1) --j; 
    else --i;    
    startPoint++;
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

PrintArray(array);
