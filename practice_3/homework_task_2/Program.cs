Console.Clear();
Console.Write("Enter A1: ");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B1: ");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter A2: ");
int A2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B2: ");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter A3: ");
int A3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B3: ");
int B3 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow((A1 - B1), 2) + Math.Pow((A2- B2), 2) + Math.Pow((A3- B3), 2));
Console.WriteLine(result);

