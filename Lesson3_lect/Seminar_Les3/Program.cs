Console.WriteLine("Enter a qourter: ");
int num = int.Parse(Console.ReadLine()!);

switch(num)
{
    case 1:
    Console.WriteLine("This is the first qourter");
    break;

    case 2:
    Console.WriteLine("This is the second quarter");
    break;

    case 3:
    Console.WriteLine("This is the third quarter");
    break;

    case 4:
    Console.WriteLine("This is the fourth quarter");
    break;

    default: Console.WriteLine("There a no quarter you enter");
    break;
}