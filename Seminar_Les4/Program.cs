// // Console.Write("Enter a number: ");
// // int userNum = int.Parse(Console.ReadLine()!); 

// // int SumCount(int num){ // Начало метода

// //     int Result = 0;
// //     for (int i = 1; i <= num; i++)
// //     {
// //         Result += i;
// //         // Console.Write($"{i} ");
// //         // Console.WriteLine($"{Result} ");
// //     }
// //     return Result;
// // }

// // Console.WriteLine(SumCount(userNum));


// //Task 1 принимает на вход число нужно вывести сколько цифр в числе

// Console.Write("Enter a number: ");
// int num = int.Parse(Console.ReadLine()!);

// int DigitCount(int num){
//     // int DigitCount = Convert.ToInt32(Math.Log10(userNum) + 1);
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
// int[] array = new int[8];
// Mass(array);
// Console.WriteLine($"Massive: {String.Join(" ", array)}");

// int[] Mass(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// int[] array = Getnumber(8);
// Console.WriteLine($"[{String.Join("-", array)}]");

// int[] Getnumber(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }

// Task 3 Найти произведение всех элементов массива целых чисел, меньших заданного числа.
// Размерность массива - 10. Заполнение массива осуществить случайными числами от 50 до 100.

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
// int[] array = MultNumbers(num);
array(mass);
Console.WriteLine($"Massive: {String.Join(" ", array)}");
// Console.WriteLine($"Произведение эл-тов массива {String.Join(", ", array)} {MultArray}");

int[] array(int num) // создал метод
{   
    int[] mass = new int[10]; // Создал пустой массив размером size
    // int total = 0; //сумма перемноженных элементов массива

    for (int i = 0; i < 10; i++)
    {   mass[i] = new Random().Next(50, 101); // наполнил массив цефрами от 50 до 100
        // if (mass[i] < num)
        // {
        //     total += mass[i] * mass[i + 1]; // результат произведения всех элементов массива, меньше num
        // }
    }
    return mass;
}

// int MultArray(int[] array, int num)
// {
//     int total = 1; //сумма перемноженных элементов массива
//     for (int i = 0; i < 10; i++)
//     {   
//         if (array[i] < num)
//         {
//             total += mass[i] * mass[i + 1];
//         }
//         mass[i] = new Random().Next(50, 101); // наполнил массив цефрами от 50 до 100
//         // if (mass[i] < num)
//         // {
//         //     total += mass[i] * mass[i + 1]; // результат произведения всех элементов массива, меньше num
//         // }
//     }
//     return total;
// }