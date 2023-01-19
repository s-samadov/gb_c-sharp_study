/*
int[] array = new int[8];
int i = 0;
while (i < array.Length)
{
     array[i] = new Random().Next(0, 2);
     Console.Write($"{array[i]} ");
     i++;
}
*/

int[] generate_array(int array_size)
{
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
int[] array = generate_array(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


