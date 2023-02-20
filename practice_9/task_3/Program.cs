Console.Clear();
Console.Write("Enter the number M: ");
int M = Convert.ToInt32(Console.ReadLine());



int Function(int M)
{
    int sum = 0;   
    if (M == 0) return 0;
    sum  = M % 10 + Function(M / 10);
    return sum;    
}
Console.WriteLine(Function(M));
