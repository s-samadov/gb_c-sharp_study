Console.Clear();
int mult_numb(int numb_a, int numb_b)
{
    int result = 1;
    for (int i = 0; i < numb_b; i++)
    {
        result = result * numb_a;
    }
    return result;
}
int end = mult_numb(2, 4);
Console.WriteLine(end);