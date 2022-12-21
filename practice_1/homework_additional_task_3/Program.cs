Console.Clear();
int N;
int elem;

Console.Write("Enter number: ");
N = int.Parse(Console.ReadLine());

for (elem = N * (-1); elem <= N; elem++)
{
    if(elem % 2 == 0)
    {
        Console.WriteLine(elem);
    }
}