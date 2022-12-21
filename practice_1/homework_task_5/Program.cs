Console.Clear();
int N;
int elem = 1;

Console.Write("Enter number: ");
N = int.Parse(Console.ReadLine());

for (elem = 1; elem < N; elem++)
{
    if(elem % 2 == 0)
    {
        Console.WriteLine(elem);
    }
}