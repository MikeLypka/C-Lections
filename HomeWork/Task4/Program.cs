Console.Write("Enter the first number: ");
string numA = Console.ReadLine();
int a = Convert.ToInt32(numA);

Console.Write("Enter the second number: ");
string numB = Console.ReadLine();
int b = Convert.ToInt32(numB);

Console.Write("Enter the third number: ");
string numC = Console.ReadLine();
int c = Convert.ToInt32(numC);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("The max number is: ");
Console.WriteLine(max);