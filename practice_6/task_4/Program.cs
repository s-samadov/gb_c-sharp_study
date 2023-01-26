Console.Clear();
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] f = new int [number];
f[0] = 0;
f[1] = 1;
for (int i = 2; i < number; i++)
{
    f[i] = f[i - 1] + f [i - 2];
}

ShowArray(f);