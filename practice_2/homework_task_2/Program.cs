Console.Clear();
int numb = new Random().Next(100, 999);
if (numb > 100 | numb < -100)
{
    while (numb > 999 | numb < -999)
	{
		numb = numb / 10;
	}
	int result = numb % 10;
    if (result < 0)
    {
        result = result * -1;
    }
    Console.WriteLine($"{numb}, {result}");
}
else
{
    Console.WriteLine("no third digit");
}