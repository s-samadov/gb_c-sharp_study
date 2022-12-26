Console.Clear();

int numb_a = new Random().Next(0, 99);
Console.Write("Number A: ");
Console.WriteLine(numb_a);
int numb_b = new Random().Next(0, 99);
Console.Write("Number B: ");
Console.WriteLine(numb_b);

if (numb_a % numb_b == 0)
{
    Console.WriteLine("multiple");
}
else
{
int res = numb_a % numb_b;
Console.Write("no multiple, remainder is ");
Console.WriteLine(res);
}

