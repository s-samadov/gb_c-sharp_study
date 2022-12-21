Console.Clear();
int a;
int b;
int c;
int max_number = 0;

Console.Write("Enter number A: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
b = int.Parse(Console.ReadLine());
Console.Write("Enter number C: ");
c = int.Parse(Console.ReadLine());

if (a>max_number) max_number = a;
if (b>max_number) max_number = b;
if (c>max_number) max_number = c;

Console.Write("Max number = ");
Console.WriteLine(max_number);
