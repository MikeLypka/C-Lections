Console.Write("Enter a number: ");
string n = Console.ReadLine();
int nInt = Convert.ToInt32(n);
int numbers = new Random().Next(1, nInt + 1);

Console.WriteLine(numbers);
