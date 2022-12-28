Console.Clear();
Console.Write("Enter X: ");
int numb_x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int numb_y = Convert.ToInt32(Console.ReadLine());

if (numb_x == 0 & numb_y == 0)
{
    Console.WriteLine("Error combination");
}
else
{
    if (numb_x > 0 & numb_y > 0)
    {
        Console.WriteLine("1 quater");
    }
    else
    {
        if(numb_x > 0 & numb_y < 0)
        {
            Console.WriteLine("4 quater");
        }
        else
        {
            if(numb_x < 0 & numb_y > 0)
            {
                Console.WriteLine("2 quater");
            }
            else
            {
                if(numb_x < 0 &numb_y < 0)
                {
                    Console.WriteLine("3 quater");
                }
            }
        }

    }
}