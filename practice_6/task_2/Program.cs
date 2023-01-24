Console.Clear();

int[] CreateTriangle(int AB, int BC, int CA)
{
    int[] res = new int[3];
    res[0] = AB;
    res[1] = BC;
    res[2] = CA;
    if (res[0] < res[1] + res[2] && res[1] < res[0] + res[2] && res[2] < res[0] + res[1])
    {
        Console.Write($"Triangle can existing with: {res[0]}, {res[1]}, {res[2]}");
    }
    else Console.WriteLine($"Triangle can't existing with: {res[0]}, {res[1]}, {res[2]}");
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = CreateTriangle(4, 4, 4);

