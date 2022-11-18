int numA = 5;
int numB = 10;

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;

Console.Write("Max number is: ");
Console.WriteLine(max);