using System;
using System.Collections.Generic;

public class NeatFreakRoommate : Roommate
{
    public NeatFreakRoommate(string name, List<string> skills) : base(name, skills) { }

    public override void ReactToAction(string action)
    {
        switch (action)
        {
            case "cleaning":
                Console.WriteLine($"{Name} already cleaned before anyone else started.");
                break;
            case "party":
                Console.WriteLine($"{Name} is wiping down counters during the party.");
                break;
            case "laundry":
                Console.WriteLine($"{Name} has their laundry color-coded and folded already.");
                break;
            case "grocery shopping":
                Console.WriteLine($"{Name} brought a labeled spreadsheet and coupons.");
                break;
            case "fixing things":
                Console.WriteLine($"{Name} is fixing things *and* cleaning the tools after.");
                break;
            case "trash":
                Console.WriteLine($"{Name} took out the trash before it even filled up.");
                break;
            case "music":
                Console.WriteLine($"{Name} is organizing the playlist by genre and mood.");
                break;
            case "church":
                Console.WriteLine($"{Name} has everyone's church clothes laid out and ironed.");
                break;
            case "family home evening":
                Console.WriteLine($"{Name} made a PowerPoint lesson and printed handouts.");
                break;
            default:
                Console.WriteLine($"{Name} is adjusting to '{action}' in the most organized way possible.");
                break;
        }
    }
}
