
// // int number = new Random().Next(1, 1000);

// // Console.WriteLine(number);
// // //Console.WriteLine($"The number without a second digit is {number/100}{number%10}");

// // int result = (number/100) * 10 + number%10;
// // Console.WriteLine(result);

// Console.WriteLine("Type three digit number: ");
// string Numbers = Console.ReadLine()!;

// if (Numbers.Length != 3)
// {
//     Console.WriteLine("You entered not three-digit number!");
// }
// else{

//     //Console.WriteLine($"The lenght of {Numbers} is {Numbers.Length}");
//     Console.WriteLine($"The number without a second digit is {Numbers[0]}{Numbers[2]}");
// }

/*
1 Задача
Написать программу, которая выводит случайное число из отрезка от 10 до 99 
и показывает наибольшую цифру числа
2 Задача
Написать программу, которая принимает на вход 2 числа и выводить является ли 
второе число кратным первому. Если нет то вывести остаток от деления. 
Первое число должно делится на второе
*/

/* First Task
int Numbers = new Random().Next(10, 100);
Console.WriteLine($"The number is {Numbers}");

int FirstNumber = Numbers/10;
int SecondNumber = Numbers%10;

if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"The biggest digit is {FirstNumber}");
}
else{
    Console.WriteLine($"The biggest digit is {SecondNumber}");
}
*/

// int FirstDigit = new Random().Next(10, 100);
// Console.WriteLine($"The first digit is {FirstDigit}");
// int SecondDigit = new Random().Next(10, 100);
// Console.WriteLine($"The second digit is {SecondDigit}");

Console.Write("Enter a first number: ");
int FirstDigit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The first digit is {FirstDigit}");
Console.Write("Enter a second number: ");
int SecondDigit = int.Parse(Console.ReadLine()!);

if (FirstDigit % SecondDigit == 0)
{
    Console.WriteLine($"The {SecondDigit} is multiple to {FirstDigit}");
}
else{
    Console.WriteLine($"The remainder of division {FirstDigit} on {SecondDigit} is {FirstDigit % SecondDigit}");
}