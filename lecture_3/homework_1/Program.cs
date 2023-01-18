//method sort max - min

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void print_array(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
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

print_array(arr);
selection_sort(arr);
print_array(arr);
