// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Type the array lenth: ");
// int num = int.Parse(Console.ReadLine()!); // запрашиваю число - количество элементов массива

// int[] Array = new int[num]; // Задаю количество элементов массива

// int MainCount = 0; // Счетчик на общее количество четных цифр
// int Count = 0; // Счетчик на количество четных цифр первого цикла i

// int[] GetArray(int[] Array){ // Формируем массив из трехзначных чисел
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(100, 400);
//     }
//     return Array;
// }

// for (int i = 0; i < Array.Length; i++)
// {
//     for (int j = 0; j < i; j++) //проверяю каждую цифру каждого трехзначного єлемента
//     {
//         if (j % 2 == 0) Count++;
        
//     }
//     MainCount += Count;
//     Count = 0; // Обнуляю счетчик
// }


// GetArray(Array); // вызываю функцию создания массива
// Console.WriteLine($"[{String.Join(", ", Array)}]"); // вывожу массив
// Console.WriteLine($"Количество четных цифр: {MainCount}");




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// // стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!); 
// int[] Array = new int[num];
// int TotalNum = 0;

// int[] GetArray(int[] Array){
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(11, 100);
//     }
//     return Array;
// }

// int TotalCount(int[] Array){
//     TotalNum = 0;
//     for (int i = 1; i < Array.Length; i += 2)
//     {
//         TotalNum += Array[i];
//     }
//     return TotalNum;
// }

// GetArray(Array);
// Console.WriteLine($"[{String.Join(", ", Array)}]");
// Console.WriteLine();
// TotalCount(Array);
// Console.WriteLine($"Сумма цифр нечетных элементов массива: {TotalNum}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

// ЗАДАЧУ НЕ ЗАКОНЧИЛ, НУЖНО СМОТРЕТЬ СЕМИНАР

// Console.Write("Введите длину массива: ");
// int num = int.Parse(Console.ReadLine()!); 
// int[] Array = new int[num];

// int[] GetArray(int[] Array){
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(11, 100);
//     }
//     return Array;
// }


// // Задача 38: Задайте массив целых чисел от -10 до 10. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// Console.Write("Введите длину массива: ");
// int num = int.Parse(Console.ReadLine()!);

// int[] Array = new int[num];
// int MaxDigit = 0;
// int MinDigit = 0;

// int[] GetArray(int[] Array){

//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = new Random().Next(-10, 10);
//     }
//     return Array;
// }

// int FindMax(int[] Array){

//     foreach (int i in Array)
//     {
//         if (i > MaxDigit) MaxDigit = i;
//     }
//     return MaxDigit;
// }

// int FindMin(int[] Array){

//     foreach (int i in Array)
//     {
//         if (i < MinDigit) MinDigit = i;
//     }
//     return MinDigit;
// }

// GetArray(Array); // вызываю функцию создания массива
// FindMax(Array);
// FindMin(Array);
// Console.WriteLine($"[{String.Join(", ", Array)}]"); // вывожу массив
// Console.WriteLine($"Максимальная цифра массива: [{MaxDigit}]");
// Console.WriteLine($"Минимальная цифра массива: [{MinDigit}]");