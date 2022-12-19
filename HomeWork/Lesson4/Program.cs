// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Enter number A: ");
// int numA = int.Parse(Console.ReadLine()!);
// Console.Write("Enter number B: ");
// int numB = int.Parse(Console.ReadLine()!);
// int count = 0;
// int sum = 1;

// while (count < numB) {
//     sum *= numA ;
//     count++;
// }
// Console.WriteLine(sum);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Enter a number: ");
// string Numbers = Console.ReadLine()!;

// DigitCount(Numbers);
// Console.WriteLine($"Total summ of digits is: {DigitCount(Numbers)}");

// int DigitCount(string num)
// {
//     int TotalSum = 0;
//     for (int i = 0; i < Numbers.Length; i++)
//     {
//         TotalSum += int.Parse($"{Numbers[i]}");
//     }
//     return TotalSum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. (числа берете любые)

// int[] array = new int[8];

// PrintArray(array);
// Console.WriteLine($"[{String.Join(" ", array)}]");

// int[] PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(101);
//     }
//     return array;
// }