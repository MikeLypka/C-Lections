Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);


// for (int i = 1; i <= n; i % 2 == 0; i++)
// {
//     Console.WriteLine(i);
// }

int n2 = 1;
if(n2 % 2 == 0)
{
while(n2 <= n)

    Console.Write($"{n2} ");
    n2 += 1;
}



