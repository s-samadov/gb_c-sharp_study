Console.Clear();
Console.Write("Enter day number: ");
int day_numb = Convert.ToInt32(Console.ReadLine());
if (day_numb == 6 | day_numb == 7)
{
    Console.Write("This is day off");
}
else
{
    if (day_numb > 7 | day_numb < 1)
    {
        Console.Write("You enter incorrect number");
    }
    else
    {
        Console.Write("This is working day");
    }
}