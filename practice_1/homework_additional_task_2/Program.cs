Console.Clear();
string today = "OMG! You shoud enter a value from 1 - 7";
int numb;

Console.Write("Enter number of the day: ");
numb = int.Parse(Console.ReadLine());
if (numb == 1) today = "Monday";
if (numb == 2) today = "Tuesday";
if (numb == 3) today = "Wednesday";
if (numb == 4) today = "Thursday";
if (numb == 5) today = "Friday"; 
if (numb == 6) today = "Saturday"; 
if (numb == 7) today = "Sunday"; 
Console.WriteLine(today);