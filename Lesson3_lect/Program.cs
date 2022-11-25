// // void Mymethod(string msg, int count)
// // {
// //     int i = 0;
// //     while (i < count)
// //     {
// //         Console.WriteLine(msg);
// //         i++;
// //     }
    
// // }
// // Mymethod(count: 5, msg: "Greetengs");

// // int MyMethod()
// // {
// //     return DateTime.Now.Year;
// // }
// // int year = MyMethod();
// // Console.WriteLine(year);

// // string MyMethod(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
    
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = MyMethod(5, "sometext");
// // Console.WriteLine(res);

// // string Method(int count, string text)
// // {
// //     string result = String.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// // //     return result;
// // }
// // string res = Method(5, "dfsf");
// // Console.WriteLine(res);

// // string MyText(int count, string text)
// // {
// //     string result = String.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string res = MyText(4, "I'm learning");
// // Console.WriteLine(res);

// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 2; j <= 10; j++)
// //     {
// //         Console.WriteLine($"{i} * {j} = {i * j}");
// //     }
// // Console.WriteLine(); }


// string text = "Борітеся - поборете! Вам Бог помагає!"
//                 + "За вас правда, за вас слава и воля святая!";

// string ReplaceChar(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;

//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == OldValue) result = result + $"{NewValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string NewText = ReplaceChar(text, 'т', 'Y');
// Console.WriteLine(NewText);
// Console.WriteLine();

// NewText = ReplaceChar(text, 'т', '0');
// Console.WriteLine(NewText);

int[] MyArr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] MyArr) // просто вывод массива
{
    int count = MyArr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(MyArr[i]);
    }
    Console.WriteLine();
}

void ArraySort(int[] MyArr) // сортировка массива
{
    for (int i = 0; i < MyArr.Length -1; i++)
    {
        int minNumber = i;
        for (int j = i + 1; j < MyArr.Length; j++)
        {
            if (MyArr[j] < MyArr[minNumber]) minNumber = j; //ищем минимальный объект
        }
        
        int tempNumber = MyArr[i];
        MyArr[i] = MyArr[minNumber];
        MyArr[minNumber] = tempNumber;
    }
}

PrintArray(MyArr);
ArraySort(MyArr);
Console.WriteLine();
PrintArray(MyArr);