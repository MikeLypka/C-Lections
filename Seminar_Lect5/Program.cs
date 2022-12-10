// Задача 21: Найдите массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных чисел массива.

// int[] array = GetArray(12, -9, 9);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int TotalNegSum = 0;
// int TotalPosSum = 0;

// foreach (int item in array)
// {
//     if (item > 0) TotalPosSum += item;
//     else TotalNegSum += item;
// }

// Console.WriteLine($"Total sum of positive digits is: {TotalPosSum}");
// Console.WriteLine($"Total sum of negative digits is: {TotalNegSum}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// Console.WriteLine();

// Задача 32. Замена элементов массива - отрицательные числа заменить на положительные и
// наоборот

// int[] MyArray = {-4, -8, 8};

// Console.WriteLine($"{String.Join(", ", TransForm(MyArray))}");

// int[] TransForm(int[] MyArray)
// {
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         MyArray[i] = -MyArray[i];

//     }
//     return MyArray;
// }


// Задача 33. Создайте массив. Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве

// int[] Array = {6, 7, 19, 345, 3};
// Console.Write("Type a number: ");
// int UserNum = int.Parse(Console.ReadLine()!);
// int Count = 0;

// for (int i = 0; i < Array.Length; i++)
    
// {
//     if (Array[i] == UserNum) Count += 1;
    
// }

// if (Count > 0) Console.Write("YES");
// else Console.WriteLine("NO");

// через bool
// if (FindNumber(Array, UserNum) == true) Console.WriteLine("YES");
// else Console.WriteLine("NO");

// bool FindNumber(int[] SomeArray, int n){
//     foreach (int i in SomeArray)
//     {
//         if (i == n) return true;  
//     }
//     return false;
// }


// Задача 35. Задайте одномерный массив из 123 случайных чисел, найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99]


int[] GetArray = new int[123];
    
for (int i = 0; i < GetArray.Length; i++)
    {
        GetArray[i] = new Random().Next(1000);
    }

int Count = 0;


foreach (int i in GetArray)
{
    if (i > 9 && i <= 99){
        Count++;
    } 
}


// Console.WriteLine($"[{String.Join(", ", GetArray)}]");
// Console.WriteLine($"[{String.Join(", ", ShowDigits)}]");
Console.WriteLine($"Number of digits is: {Count}");