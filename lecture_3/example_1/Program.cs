 // var 1 don't return
 void Method1()
 {
    Console.WriteLine("Autor is S.Samadov");
 }

Method1();

 // var 2 don't return
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2(msg: "Message text", count: 5);

// var 3 return 
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// var 4 return
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(4, "qwerty");
Console.WriteLine(res);