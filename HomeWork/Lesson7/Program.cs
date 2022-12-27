//Задача 47. 
/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Console.WriteLine("Type rows amount: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Type columns amount: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);


// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(minValue - maxValue);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i, j]):f2} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. 
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

i = 5; j = 2 -> такого числа в массиве нет
i = 1; j = 1 -> 9
*/

// int[,] array = GetArray(3, 4, 0, 10);

// PrintArray(array);
// Console.WriteLine("Type a number: ");
// int UserNum = int.Parse(Console.ReadLine()!);
// // GetWhichIndex(array);
// if (GetWhichIndex(array, UserNum))
// {
//     Console.WriteLine("num is found");
// }
// else
// {
//     Console.WriteLine("There is not such num in the array");
// }


// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool GetWhichIndex(int[,] array, int UserNum)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (UserNum == array[i, j]) return true;

//         }
//     }
//     return false;
// }

// Задача 52. 
/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Type rows amount: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Type columns amount: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();
GetAverageNum(array);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverageNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++) // Счетчик i по колонкам
    {
        double total = 0;
        for (int j = 0; j < array.GetLength(0); j++) // Счетчик j по рядам
        {
            total += array[i, j];
        }
        Console.WriteLine($" {(total / array.GetLength(0)):f2}");
    }
    Console.WriteLine();
}
 