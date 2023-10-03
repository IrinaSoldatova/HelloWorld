// See https://aka.ms/new-console-template for more information
Console.Write("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "ira")
{
    Console.WriteLine("Wow! It`s Ira!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
