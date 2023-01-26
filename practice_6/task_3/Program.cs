

Console.Clear();
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Convert.ToInt32(Math.Log2(number)) + 1];
int i = 0;
while (number > 0)
{
    Console.Write($"{number % 2} ");
    array[array.Length - i - 1] = number % 2;
    i++;
    number = number / 2; 
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
ShowArray(array);