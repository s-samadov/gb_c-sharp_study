Console.Clear();
Console.Write("Enter XXXXX number: ");
string number = Console.ReadLine();
int n = number.Length;

if(n > 4 & n < 6)
{
    if(number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine("This number is a palindrome");
    }
    else
    {
        Console.WriteLine("This number is not a palindrome");
    }
}
else
{
    Console.WriteLine("Incorrect number");
}