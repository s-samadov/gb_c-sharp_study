Console.Clear();
int sum_numb(int number)
{
    int i = 1;
    int result = 1;
    while (i <= number)
    {
        result = result * i;
        i++; 
    }
    return result;
}
int sum = sum_numb(5);
Console.WriteLine(sum);