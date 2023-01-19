Console.Clear();
int numb_cal (int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
int check = numb_cal(452);
Console.WriteLine(check);