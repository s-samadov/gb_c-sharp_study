Console.Clear();

int[] CreateRandomArray(int size, int min_number, int max_number)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min_number, max_number);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = CreateRandomArray(4, 1, 10);
PrintArray(array);

/*
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.WriteLine();
ReverseArray(array);
PrintArray(array);
*/


int[] newArray=new int[array.Length];

void NewArray(int[] array)
{
   for(int i=0; i<array.Length; i++) newArray[i]=array[array.Length - 1 - i];
}

Console.WriteLine();
NewArray(array);
PrintArray(newArray);

