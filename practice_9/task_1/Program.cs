Console.Clear();
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Function(n);
void Function(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return;
    Function(n - 1);
}
