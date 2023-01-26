Console.Clear();
Console.WriteLine("Enter value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value k2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Lines are parallel");
    
}
else
{
    double x = (-b1 + b2) / (k1 - k2);  
    double y = k2 * x + b2;
    Console.WriteLine($"Intersection point: {x}, {y}");
}