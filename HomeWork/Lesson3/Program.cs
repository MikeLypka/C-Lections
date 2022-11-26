// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Enter a number: ");
// string numbers = Console.ReadLine()!;

// if (numbers.Length == 5)
// {
//     if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
//     {
//         Console.WriteLine("Yes, it's a palindrome");
//     }
//     else
//     {
//         Console.WriteLine("No, it doesn't palindrome");
//     }
// }
// else
// {
//     Console.WriteLine("Entered number doesn't consist of 5 digits!");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int[] A = {3, 6, 8};
// int[] B = {2, 1, -7};
// // int[] A = {7, -5, 0};
// // int[] B = {1, -1, 9};

// double dist = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2));
// Console.WriteLine($"{dist:f2}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Enter a number: ");
// int N = int.Parse(Console.ReadLine()!);
// if (N < 0)
// {
//     N = -N;
// }
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }