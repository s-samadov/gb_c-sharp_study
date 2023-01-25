Console.Clear();
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (number > 0)
{
    Console.Write(number % 2);
    number = number / 2; 
}

