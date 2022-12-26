int numb = new Random().Next(100, 999);
int res1 = numb / 100;
int res2 = numb % 10;
Console.WriteLine(res1);
Console.WriteLine(res2);
int res3 = res1 * 10 + res2;
Console.WriteLine(res3);
