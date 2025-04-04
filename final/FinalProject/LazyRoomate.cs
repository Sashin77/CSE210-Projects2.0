using System;
using System.Collections.Generic;

public class LazyRoommate : Roommate
{
    public LazyRoommate(string name, List<string> skills) : base(name, skills) { }

    public override void ReactToAction(string action)
    {
        switch (action)
        {
            case "cleaning":
                Console.WriteLine($"{Name} is doing nothing when it comes to cleaning. Probably watching TV.");
                break;
            case "party":
                Console.WriteLine($"{Name} is eating all the snacks at the party, even though they didn't do anything to help.");
                break;
            case "laundry":
                Console.WriteLine($"{Name} is ignoring their laundry. It's piling up.");
                break;
            case "grocery shopping":
                Console.WriteLine($"{Name} doesn't care about grocery shopping. Maybe ordering pizza?");
                break;
            case "fixing things":
                Console.WriteLine($"{Name} doesn't know how to fix anything, leaving it broken.");
                break;
            case "trash":
                Console.WriteLine($"{Name} is ignoring the trash. It smells.");
                break;
            case "music":
                Console.WriteLine($"{Name} is probably asleep while everyone else listens to music.");
                break;
            case "church":
                Console.WriteLine($"{Name} is still sleeping, not going to church today. Bro you have a calling!");
                break;
            case "family home evening":
                Console.WriteLine($"{Name} is skipping family home evening, watching TV instead.");
                break;
            default:
                Console.WriteLine($"{Name} doesn't know how to react to this action.");
                break;
        }
    }
}
