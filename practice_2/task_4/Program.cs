Console.Clear();
int numb;
Console.Write("Enter number: ");
numb = int.Parse(Console.ReadLine());
if (numb % 7 == 0 & numb % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}