using System;
using System.Collections.Generic;

public abstract class Roommate
{
    public string Name { get; set; }
    public List<string> Skills { get; set; }

    public Roommate(string name, List<string> skills)
    {
        Name = name;
        Skills = skills;
    }

    public abstract void ReactToAction(string action);

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Name} has the following skills: {string.Join(", ", Skills)}");
    }
}
