Console.Write("Enter a number: ");
// string n = Console.ReadLine();
// int num = Convert.ToInt32(n);
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
{
    Console.WriteLine("Yes");
} 
else
{
    Console.WriteLine("No");
}