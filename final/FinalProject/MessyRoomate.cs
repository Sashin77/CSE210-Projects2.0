using System;

public class MessyRoommate : Roommate
{
    public bool IsMessy { get; set; }

    public MessyRoommate(string name, string personality, string[] skills, bool isMessy)
        : base(name, personality, skills)
    {
        IsMessy = isMessy;
    }

    public override void DoChores()
    {
        if (IsMessy)
        {
            Console.WriteLine($"{Name} left the dishes unwashed and clothes everywhere.");
        }
        else
        {
            Console.WriteLine($"{Name} is keeping their space messy.");
        }
    }

    public void ShowMessiness()
    {
        if (IsMessy)
        {
            Console.WriteLine($"{Name} is very messy!");
        }
        else
        {
            Console.WriteLine($"{Name} is tidy.");
        }
    }
}
