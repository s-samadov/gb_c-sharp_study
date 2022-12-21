Console.Clear();
int a;
int b;
int max_number;

Console.Write("Enter number A: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    max_number = a;
}
else
{
    max_number = b;
}
Console.Write("Max number: ");
Console.Write(max_number);



