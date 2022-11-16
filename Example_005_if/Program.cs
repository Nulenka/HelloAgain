Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username == "Marusya")
{
    Console.WriteLine("Hurray, it's Marusya!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

Console.Write("Enter username1: ");
string username1 = Console.ReadLine();

if(username1.ToLower() == "marusya")
{
    Console.WriteLine("Hurray, it's Marusya!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username1);
}