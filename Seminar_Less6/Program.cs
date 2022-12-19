// // Задача 39: Напишите программу, которая перевернет одномерный массив
// // (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] array = GetArray(10, 0, 10); // Вызываем метод GetArray для формирования массива
// Console.WriteLine($"[{String.Join(", ", array)}]"); // Выводим массив

// ReverseArray1(array);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] result = ReverseArray2(array);
// Console.WriteLine($"[{String.Join(", ", result)}]");

// // -----------------Методы----------------------------
// int[] GetArray(int size, int minValue, int maxValue){ // формируем новый массив
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void ReverseArray1 (int[] array){ // реверсируем массив
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp; 
//     }
// }

// int[] ReverseArray2 (int[] array){ // реверсируем массив, второй способ
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         result[i] = array[array.Length - i - 1];
//     }
//     return result;
// }


// Задача 40: 
/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины. (Теорема о неравенстве треугольника: 
каждая сторона треугольника меньше суммы двух других сторон.) */

// Console.WriteLine("enter number a: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("enter number b: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("enter number c: ");
// int c = int.Parse(Console.ReadLine()!);

// if (Triangle(a, b, c))
// {
//     Console.Write("That triangle is exist");
// }
// else
// {
//     Console.WriteLine("Not exist");
// }

// bool Triangle(int a, int b, int c)
// {
//     if (c < (a + b) && a < (b + c) && b < (a + c))
//     {
//         return true;
//     }
//     return false;
// }

// Задача 42: 
/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
(число делится на 2 до самого конца, а потом остатки записываются, начиная с конца)*/

// Console.WriteLine("Enter a number: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n);

// Console.WriteLine(ToByte(n));

// string ToByte(int num)
// {   
//     string result = "";
//     while (num != 0)
//     {
//         int num1 = num % 2;
//         num = num / 2;
//         string num3 = Convert.ToString(num1);
//         result += num1;
    
//     }
//     return result;
    
// }

// Задача 44: 
/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
(Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.)
если n = 5 -> 0 1 1 2 3
*/

// int n = 20;
// int first = 0;
// int second = 1;
// Console.Write($"{first} {second}");

// for (int i = second + 1; i < n; i++)
// {
//     int num = 0;
//     num = first + second;
//     Console.Write($" {num}");
//     first = second;
//     second = num;  
// }

// Задача 45: 
/* Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.*/

int[] array = GetArray(10, 0, 10); // Вызываем метод GetArray для формирования массива
Console.WriteLine($"[{String.Join(", ", array)}]"); // Выводим массив

CopyArray(array);

Console.WriteLine($"Копия массива: [{String.Join(", ", CopyArray(array))}]"); // Выводим массив

int[] GetArray(int size, int minValue, int maxValue){ // формируем новый массив
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] CopyArray(int[] SomeArray) // Метод копирования массива
{
    int[] result = new int[SomeArray.Length];
    for (int i = 0; i < SomeArray.Length; i++)
    {
        result[i] = SomeArray[i];
    }
    return result;
}
