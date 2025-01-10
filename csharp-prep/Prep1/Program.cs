using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please tell us your first name! ");
        string firstName = Console.ReadLine();

        Console.Write("Please tell us your last name! ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Ah! Your name is {lastName}, {firstName} {lastName}.");
    }
}
