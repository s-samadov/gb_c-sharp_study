Console.OutputEncoding = System.Text.Encoding.UTF8; // correct coding method for input/output
Console.InputEncoding = System.Text.Encoding.UTF8;

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

Console.WriteLine(text);
string Replace(string text, char old_value, char new_value)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == old_value) result = result + $"{new_value}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string new_text = Replace(text, ' ', '|');
Console.WriteLine(new_text);
Console.WriteLine();
new_text = Replace(new_text, 'к', 'К');
Console.WriteLine(new_text);
Console.WriteLine();
new_text = Replace(new_text, 'С', 'с');
Console.WriteLine(new_text);