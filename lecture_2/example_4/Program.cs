void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index + 1;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index = index + 1;
    }
    return position;
}

int[] array_3 = new int[10]; // create new massive with len 10

FillArray(array_3);
PrintArray(array_3);
Console.WriteLine();

int pos = IndexOf(array_3, 444);
Console.WriteLine(pos);