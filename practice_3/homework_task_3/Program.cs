Console.Clear();
int i = 1;
Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

while (i <= N)
{
    Console.WriteLine(Math.Pow(i, 3));
    i ++;   
}