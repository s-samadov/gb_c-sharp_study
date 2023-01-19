Console.Clear();
int numb_cal (int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        number = number / 10;
        if (number >= 0)
        {
            result++;
        }
    }
    return result;
}
int check = numb_cal(456);
Console.WriteLine(check);