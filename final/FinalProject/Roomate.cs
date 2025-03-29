using System;

public class Roommate
{
    public string Name { get; set; }
    public string Personality { get; set; }
    public string[] Skills { get; set; }

    public Roommate(string name, string personality, string[] skills)
    {
        Name = name;
        Personality = personality;
        Skills = skills;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {Name}. My personality is {Personality}.");
        Console.WriteLine("Skills: " + string.Join(", ", Skills));
    }

    public virtual void DoChores()
    {
        Console.WriteLine($"{Name} is doing basic chores.");
    }
}
