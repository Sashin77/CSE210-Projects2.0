using System;
using System.Collections.Generic;
using System.IO;

class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Pick your flavor of suffering:");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal (No escape!)\n3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Name your challenge: ");
        string name = Console.ReadLine();
        Console.Write("How many points is this worth? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("How many times must this be done? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus for completion? ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].Display()}");

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            int earned = goals[choice].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points! Total score: {score}");
        }
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Legendary Tasks:");
        foreach (var goal in goals)
            Console.WriteLine(goal.Display());
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveProgress()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
                writer.WriteLine(goal.Save());
        }
    }

    public void LoadProgress()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts[0] == "Simple") goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])) { });
                else if (parts[0] == "Eternal") goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                else if (parts[0] == "Checklist") goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[5])));
            }
        }
    }
}
