// Console.Write("Enter a number: ");
// int userNum = int.Parse(Console.ReadLine()!); 

// int SumCount(int num)
// { // Начало метода

//     int Result = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         Result += i;
//         Console.Write($"{i} ");
//         Console.WriteLine($"{Result} ");
//     }
//     return Result;
// }

// Console.WriteLine(SumCount(userNum));


//Task 1 принимает на вход число нужно вывести сколько цифр в числе

// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);

// int DigitCount(int num)
// { // Начало метода
//     int counter = 0;

//     while (num > 0)
//     {
//         counter++;
//         num = num / 10;
//     }
//     return counter;
// }

// Console.WriteLine($"Number is consist of {DigitCount(num)} digits");

//Task 2
// Console.WriteLine("Enter a length: "); // введите длину массива
// int User = int.Parse(Console.ReadLine()!); // ввод длины массива

// int[] array = new int[User]; // Длина массива вводится

// Mass(array);
// // Console.WriteLine($"Massive: {String.Join(" ", array)}");

// int[] Mass(int[] array){ // Заполняем массив 8 случайными числами от 0 до 1)
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(2);
//     }
//     return array;
// }

// void PrintArray(int[] array) // метод, который выводит на печать массив
// {
//     Console.WriteLine($"Massive: [{String.Join(" ", array)}]");
// }

// PrintArray(array);

// Task 3 Найти произведение всех элементов массива целых чисел, меньших заданного числа.
// Размерность массива - 10. 
// Заполнение массива осуществить случайными числами от 50 до 100.

int[] array = new int[10]; // Задаем массив размерностью 10

int[] Mass(int[] array){ // Заполняем массив 10 случайными числами от 50 до 100)
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(50, 101);
    }
    return array;
}
Mass(array);
Console.WriteLine($"[{String.Join(" ", array)}]");
Console.WriteLine("Enter a number: "); // запрашиваем число у пользователя
int num = int.Parse(Console.ReadLine()!); // считываем введенное число

int MultArray(int[] array, int number){ // Метод подсчета произведение чисел
    int multiple = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < num) multiple *= array[i]; 
        
    }
    return multiple;
}

Console.WriteLine($"Произведение элементов массива меньше {num}: {MultArray(array, num)}");
