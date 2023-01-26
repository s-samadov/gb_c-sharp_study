Console.Clear();
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i < number; i = i + result)
{
    Console.Write($"{i} ");
    result=i-result;
}
 
 