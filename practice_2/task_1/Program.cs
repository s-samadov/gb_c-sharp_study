Console.Clear();
int result;
int result_2;
int numb = new Random().Next(10, 99);
result = numb % 10;
result_2 = numb / 10;

Console.WriteLine(numb);
if (result_2 > result)
{
    Console.WriteLine(result_2);
}
else
{
Console.WriteLine(result);
}