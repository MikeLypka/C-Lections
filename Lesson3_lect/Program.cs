// void Mymethod(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
    
// }
// Mymethod(count: 5, msg: "Greetengs");

// int MyMethod()
// {
//     return DateTime.Now.Year;
// }
// int year = MyMethod();
// Console.WriteLine(year);

// string MyMethod(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
    
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = MyMethod(5, "sometext");
// Console.WriteLine(res);

string Method(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++);
    {
        result = result + text;
    }
    return result;
}
string res = Method(5, "dfsf");
Console.WriteLine(res);