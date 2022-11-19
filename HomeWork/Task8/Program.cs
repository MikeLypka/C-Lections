Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);

int n2 = 1;

while(n2 <= n)
{
    if(n2 % 2 == 0)
    Console.Write($"{n2} ");
    n2 += 1;
    
}



