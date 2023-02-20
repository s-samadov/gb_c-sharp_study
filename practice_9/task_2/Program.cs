Console.Clear();
Console.Write("Enter the number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int N = Convert.ToInt32(Console.ReadLine());

Function(M, N);
void Function(int M, int N)
{
    Console.Write($"{M} ");
    if (M == N) return;
    Function(M + 1, N);
}
