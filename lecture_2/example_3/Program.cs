int[] array_2 = {1, 102, 14, 19, 2, 102, 60, 8};
int n = array_2.Length;
int find = 102;
int index = 0;
while (index < n)
{
    if(array_2[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1; // index++
}