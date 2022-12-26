Console.Clear();
int numb_A;
int numb_B;

Console.Write("Enter number A: ");
numb_A = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
numb_B = int.Parse(Console.ReadLine());

if (numb_B * numb_B == numb_A | numb_A * numb_A == numb_B)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}