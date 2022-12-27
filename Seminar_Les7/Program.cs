// Задача 46: Задайте двумерный массив, размером m, n , заполненный случайными числами.


// Console.Write("Введите длину строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите длину столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9); // Создание массива через метод GeyArray

// int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создания массива
// {
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

// void PrintArray(int[,] array) // Метод вывода массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");   
//         }
//     Console.WriteLine();
//     }
// }


// PrintArray(array);

// Задача 48: 
/* Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

// Console.Write("Введите длину строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите длину столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//             // result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//     Console.WriteLine();
//     }
    
// }

// PrintArray(array);

//Задача 49: 
/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:

1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// Console.Write("Введите длину строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите длину столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);

// int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создания массива
// {
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

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }   
//     Console.WriteLine();
//     }
// }

// void ArrayTask(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] = (int)Math.Pow(array[i, j], 2);
//         }
//     }
// }

// PrintArray(array);
// Console.WriteLine();
// ArrayTask(array);
// PrintArray(array);


// Задача 51: 
/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12

Также задача: Задать двумерный массив и отсортировать нечетные столбцы по возрастанию

Подсказка к дз с выводом вещественных чисел: Console.Write($"{array[i,j]:f2}"); В методе печати массива :)
*/

// Console.Write("Введите длину строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите длину столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9); // Создание массива через метод GeyArray

// int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод создания массива
// {
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

// void PrintArray(int[,] array) // Метод вывода массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");   
//         }
//     Console.WriteLine();
//     }
// }

// void GetDiag(int[,] array){
//     int total = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   if (i == j){
//             Console.Write($"{array[i, j]} ");
//             total += array[i, j];
//         }
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма по диагонали - {total}");
// }


// PrintArray(array);
// Console.WriteLine();
// GetDiag(array);

