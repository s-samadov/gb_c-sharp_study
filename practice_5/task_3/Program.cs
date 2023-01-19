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

int[] array = create_random_array(4, 0, 6);
show_array(array);

int omg_test = 0;
int number = 5;
for (int i = 0; i < array.Length; i++)
{   
    if (array[i] == number)
    {
        omg_test = 1;
    } 
}
if (omg_test == 1)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}