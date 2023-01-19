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

void show_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] invert_array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] array = create_random_array(4, -10, 10);
show_array(array);
int[] array2 = invert_array(array);
show_array(array2);
