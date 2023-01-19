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

int[] array = create_random_array(123,-999, 999);
show_array(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 & array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"\nresult is: {count}");