Console.Clear();
Console.Write("Enter the number: ");
int m = Convert.ToInt32(Console.ReadLine());
Function(1, m);
void Function(int n, int m)
{
    Console.Write($"{n} ");
    if (n == m) return;
    Function(n+1, m);
}
