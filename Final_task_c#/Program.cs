Console.Clear();
Console.Write("Enter count of elemets in array: ");
int elCount = Convert.ToInt32(Console.ReadLine());

string[] array = new string[elCount];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter element of array: ");
    array[i] = Console.ReadLine();
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Array elements whose length <= 3 characters long: ");
PrintArray(array);
