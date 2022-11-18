Console.Write("Enter the first number: ");
string a = Console.ReadLine();
int numA = Convert.ToInt32(a);

Console.Write("Enter the second number: ");
string b = Console.ReadLine();
int numB = Convert.ToInt32(b);

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;

Console.Write("Max number is: ");
Console.WriteLine(max);