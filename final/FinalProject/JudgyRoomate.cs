using System;
using System.Collections.Generic;

public class JudgyRoommate : Roommate
{
    public JudgyRoommate(string name, List<string> skills) : base(name, skills) { }

    public override void ReactToAction(string action)
    {
        switch (action)
        {
            case "cleaning":
                Console.WriteLine($"{Name} says, 'Wow, took you long enough to clean that.'");
                break;
            case "party":
                Console.WriteLine($"{Name} scoffs, 'Another party? You think you're in college or something?'");
                break;
            case "laundry":
                Console.WriteLine($"{Name} raises an eyebrow, 'Washing whites with colors? Really?'");
                break;
            case "grocery shopping":
                Console.WriteLine($"{Name} mutters, 'That’s what you call groceries?'");
                break;
            case "fixing things":
                Console.WriteLine($"{Name} crosses their arms, 'You call *that* fixed?'");
                break;
            case "trash":
                Console.WriteLine($"{Name} sighs loudly, 'Took a week, but someone *finally* noticed the trash.'");
                break;
            case "music":
                Console.WriteLine($"{Name} says, 'This playlist is... a choice.'");
                break;
            case "church":
                Console.WriteLine($"{Name} smirks, 'Some people *really* need that lesson on humility today.'");
                break;
            case "family home evening":
                Console.WriteLine($"{Name} critiques your lesson mid-way through it.");
                break;
            default:
                Console.WriteLine($"{Name} silently judges you for doing '{action}'.");
                break;
        }
    }
}
