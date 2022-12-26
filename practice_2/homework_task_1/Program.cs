Console.Clear();
int numb = new Random().Next(100, 999);
Console.Write($"{numb}, ");
int res1 = numb % 100 / 10;
Console.WriteLine(res1);