Console.Clear();
Console.Write("Enter the number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N: ");
int N= Convert.ToInt32(Console.ReadLine());



int Function(int M, int N, int sum)
{
    if (M <= N)
    {
        sum  = sum + M;
        M++;
        return Function(M, N, sum);
    }
    return sum;  
}
Console.WriteLine($"Sum of the numbers is: {Function(M, N, 0)}");
