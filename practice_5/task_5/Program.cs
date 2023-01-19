Console.Clear();

int[] array = {1,2,3,4,5};
if (array.Length % 2 == 0)
{
    int[] array2 = new int[array.Length/2];
    for (int i = 0; i <array.Length / 2; i++)
    {
        array2[i] = array[i] * array[array.Length - 1 - i];
    }
    Console.WriteLine($"{String.Join(", ", array)}");
    Console.WriteLine($"{String.Join(", ", array2)}");
}
else
{
    int[] array2 = new int[array.Length/2 + 1];
    for (int i = 0; i <array.Length / 2; i++)
    {
        array2[i] = array[i] * array[array.Length - 1 - i];
    }
    Console.WriteLine($"{String.Join(", ", array)}");
    Console.WriteLine($"{String.Join(", ", array2)}");
}





