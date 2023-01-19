Console.Clear();

int[] create_array (int array_min_numb, int array_max_numb)
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        result[i] = new Random().Next(array_min_numb, array_max_numb);
    }
    return result;
}
int[] array = create_array(-999, -666);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


