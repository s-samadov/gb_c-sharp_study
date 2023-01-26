Console.Clear();
Console.WriteLine("Enter various numbers: ");
Console.WriteLine("Enter number 999 for stop");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
while (true)
{
    if (number == 999) // for stop
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter another number: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            j++;
        }
    }
    i++;
}
Console.WriteLine($"Number greater than 0: {j}");