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

int[] array = create_random_array(12, -9, 9);
show_array(array);

int pos_number = 0;
int neg_number = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        pos_number = pos_number + array[i];
    }
    else
    {
        neg_number = neg_number + array[i];
    }
}
Console.WriteLine($"pos:{pos_number}\nneg:{neg_number}");