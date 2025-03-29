// ResponsibleRoommate.cs
using System;

public class ResponsibleRoommate : Roommate
{
    public bool IsResponsible { get; set; }

    public ResponsibleRoommate(string name, string personality, string[] skills, bool isResponsible)
        : base(name, personality, skills)
    {
        IsResponsible = isResponsible;
    }

    public override void DoChores()
    {
        if (IsResponsible)
        {
            Console.WriteLine($"{Name} always pays the bills on time and does all the chores.");
        }
        else
        {
            Console.WriteLine($"{Name} sometimes forgets their responsibilities.");
        }
    }

    public void ShowResponsibility()
    {
        if (IsResponsible)
        {
            Console.WriteLine($"{Name} is extremely responsible.");
        }
        else
        {
            Console.WriteLine($"{Name} isn't always responsible.");
        }
    }
}
