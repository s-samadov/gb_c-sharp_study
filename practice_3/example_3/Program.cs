void print_xy(int quater)
{
    if(quater == 1)
    {
        Console.WriteLine("x>0 & y>0");
    }
    else if(quater == 2)
    {
        Console.WriteLine("x<0 & y>0");
    }
    else if(quater == 3)
    {
        Console.WriteLine("x<0 & y<0");
    }
    else if(quater == 4)
    {
        Console.WriteLine("x>0 & y<0");
    }
    else
    {
        Console.WriteLine("Incorrect quater number");
    }
}

Console.Clear();
Console.Write("Enter quater number: ");
int numb = Convert.ToInt32(Console.ReadLine());
print_xy(numb);