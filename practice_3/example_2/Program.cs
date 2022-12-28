void print_coordinate(int numb_x, int numb_y)
{
if (numb_x > 0 & numb_y > 0)
{
    Console.WriteLine("1 quater");
}

else if (numb_x > 0 & numb_y < 0)
{
    Console.WriteLine("4 quater");
}

else if (numb_x < 0 & numb_y > 0)
{
    Console.WriteLine("2 quater");
}

else if (numb_x < 0 & numb_y < 0)
{
    Console.WriteLine("3 quater");
}
else
{
    Console.WriteLine("Incorrect combination");
}
}

Console.Clear();
Console.Write("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());
print_coordinate(x, y);