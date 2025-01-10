using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your or the student's grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string grade = "";
        string sign = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (grade != "F")
        {
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (grade == "A" && sign == "+")
        {
            sign = ""; 
        }
        if (grade == "F")
        {
            sign = ""; 
        }

        Console.WriteLine($"The grade is: {grade}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Success, this class was passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, the class was not passed, with this grade.");
        }
    }
}
