using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userFirstName = PromptUserFirstName();
        string userLastName = PromptUserLastName();
        int userFavoriteNumber = PromptUserFavoriteNumber();

        int squaredNumber = SquareNumber(userFavoriteNumber);

        DisplayResult(userFirstName, userLastName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome! Let's embark on this numerical journey.");
    }

    static string PromptUserFirstName()
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();

        return firstName;
    }

    static string PromptUserLastName()
    {
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();

        return lastName;
    }

    static int PromptUserFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string firstName, string lastName, int square)
    {
        Console.WriteLine($"{firstName} {lastName}, the square of your number is {square}");
    }
}
