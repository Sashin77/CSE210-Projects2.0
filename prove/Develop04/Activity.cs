using System;
using System.Threading;

class Activity
{
    public string Name;
    public string Activity_Description;
    public int Duration;
    private static int totalPoints = 0;

    public Activity(string name, string activityDescription)
    {
        Name = name;
        Activity_Description = activityDescription;
    }

    public virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} Activity.");
        Console.WriteLine(Activity_Description);
        Console.Write("Please enter the duration for the activity (seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready! It's starting soon!");
        ShowProgressBar(3);
    }

    public void End()
    {
        Console.WriteLine("Way to go! You completed the activity!");
        Console.WriteLine($"Hey! You spent {Duration} seconds on this {Name} Activity!");
        AwardPoints();
        ShowProgressBar(3);
    }

    protected void ShowProgressBar(int seconds)
    {
        Console.WriteLine("\nProgress:");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\r[");
            for (int j = 0; j <= i; j++) Console.Write("█");
            for (int j = i + 1; j < seconds; j++) Console.Write("-");
            Console.Write($"] {i + 1}/{seconds} sec");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\nDone!");
    }

    private void AwardPoints()
    {
        int points = Duration / 10;
        totalPoints += points;
        Console.WriteLine($"You earned {points} points! Total points: {totalPoints} 🎉");
    }
}
