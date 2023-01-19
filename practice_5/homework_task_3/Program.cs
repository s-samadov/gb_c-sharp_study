Console.Clear();

int[] create_random_array(int size, int min_number, int max_number)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min_number, max_number);
    }
    return result;
}

int[] array = create_random_array(4, -999, 999);

void print_array(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void selection_sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int max_position = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[max_position]) max_position = j;
        }
        int temporary = array[i];
        array[i] = array [max_position];
        array[max_position] = temporary;
    }
}

Console.Write("Before sort: ");
print_array(array);
selection_sort(array);
Console.Write("After sort: ");
print_array(array);

int result = array[0] - array[array.Length - 1];
Console.Write($"result(max-min): {result}");