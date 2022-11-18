int a = 44, b = 5, c = 78;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("The max number is: ");
Console.WriteLine(max);