Console.Clear();
int numb;

Console.Write("Enter number: ");
numb = int.Parse(Console.ReadLine());

if (numb % 2 == 0)
{
    Console.Write("honest");
}
else
{
    Console.Write("odd");
}