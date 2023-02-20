Console.Clear();
Console.Write("Enter the number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int N= Convert.ToInt32(Console.ReadLine());

int Function(int M, int N)
{
    if (M == 0)
        return N + 1;
    else
    if ((M != 0) && (N == 0))
        return Function(M - 1, 1);
    else
        return Function(M - 1, Function(M, N - 1));
}
Console.Write(Function(M, N));