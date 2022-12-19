// Задача 41:  
/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
// int n = 5;
// int Count = 0;
// while (n > 0){
//     Console.Write("Введите число: ");
//     int c = int.Parse(Console.ReadLine()!);
//     if (c > 0) Count += 1;
//     n--;
// }
// Console.WriteLine($"Количество цифр больше 0: {Count}");


// Задача 43: 
/* Написать программу, которая на вход принимает массив из любого количества элементов 
(не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный 
по возрастанию(от меньшего числа к большему). */

int[] array = GetArray(10, 0, 100); // Вызываем метод GetArray для формирования массива
Console.WriteLine($"[{String.Join(", ", array)}]"); // Выводим массив

sortArray(array);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue){ // формируем новый массив
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void sortArray(int[] someArray){

    for (int i = 0; i < someArray.Length - 1; i++)
    {
        int minDigit = i;
        for (int j = i + 1; j < someArray.Length; j++)
        {
            if (someArray[j] < someArray[minDigit]) minDigit = j;
        }

        int tempDigit = someArray[i];
        someArray[i] = someArray[minDigit];
        someArray[minDigit] = tempDigit;

    }
}
