Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "mike")
{
    Console.WriteLine("Ooh, it's Mike!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}