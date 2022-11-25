// Console.WriteLine("Enter a qourter: ");
// int num = int.Parse(Console.ReadLine()!);

// switch(num)
// {
//     case 1:
//     Console.WriteLine("This is the first qourter");
//     break;

//     case 2:
//     Console.WriteLine("This is the second quarter");
//     break;

//     case 3:
//     Console.WriteLine("This is the third quarter");
//     break;

//     case 4:
//     Console.WriteLine("This is the fourth quarter");
//     break;

//     default: Console.WriteLine("There a no quarter you enter");
//     break;
// }

// Task 17

// Console.WriteLine("Enter six-digit number");
// string numbers = Console.ReadLine();

// Console.WriteLine(numbers);

// // int num1 = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[2]);
// // int num2 = Convert.ToInt32(numbers[3]) + Convert.ToInt32(numbers[4]) + Convert.ToInt32(numbers[5]);


// int num1 = (numbers[0] + numbers[1] + numbers[2]);
// int num2 = (numbers[3] + numbers[4] + numbers[5]);


// if (num1 == num2)
// {
//     Console.WriteLine("The number is happy");
// }
// else
// {
//     Console.WriteLine("The number is unhappy");
// }
// Console.WriteLine(num1);
// Console.WriteLine(num2);

// int[] myArr = {7, -5, 1, -1};

// double dist = Math.Sqrt(Math.Pow(myArr[0] - myArr[2], 2) + Math.Pow(myArr[1] - myArr[3], 2));
// Console.WriteLine($"{dist:f2}");

// Task
// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов числе от 1 до N.

Console.Write("Enter a number: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}
