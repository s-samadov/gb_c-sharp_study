Console.Clear();
int sum_numb(int number)
{
    int i = 0;
    int result = 0;
    while (i <= number)
    {
        result = result + i;
        i++; 
    }
    return result;
}
int sum = sum_numb(2);
Console.WriteLine(sum);