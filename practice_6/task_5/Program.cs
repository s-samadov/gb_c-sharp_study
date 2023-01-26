Console.Clear();

Console.Clear();

int[] CreateRandomArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] CopyArray(int[] array)
{
    int [] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int[] array = CreateRandomArray(5);
ShowArray(array);
Console.WriteLine();
int[] copyArray = CopyArray(array);
ShowArray(copyArray);
