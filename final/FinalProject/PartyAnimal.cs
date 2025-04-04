using System;
using System.Collections.Generic;

public class PartyAnimalRoommate : Roommate
{
    public PartyAnimalRoommate(string name, List<string> skills) : base(name, skills) { }

    public override void ReactToAction(string action)
    {
        switch (action)
        {
            case "cleaning":
                Console.WriteLine($"{Name} is dancing while sweeping, but making a bigger mess.");
                break;
            case "party":
                Console.WriteLine($"{Name} just invited 30 people over. This party is lit!");
                break;
            case "laundry":
                Console.WriteLine($"{Name} forgot about laundry... again.");
                break;
            case "grocery shopping":
                Console.WriteLine($"{Name} bought chips, soda, and glitter. That's it.");
                break;
            case "fixing things":
                Console.WriteLine($"{Name} tried fixing things but ended up breaking more.");
                break;
            case "trash":
                Console.WriteLine($"{Name} turned the trash chore into a TikTok challenge.");
                break;
            case "music":
                Console.WriteLine($"{Name} turned the volume all the way up. Neighbors are mad.");
                break;
            case "church":
                Console.WriteLine($"{Name} is inviting everyone to the after-church brunch.");
                break;
            case "family home evening":
                Console.WriteLine($"{Name} brought karaoke to family home evening.");
                break;
            default:
                Console.WriteLine($"{Name} turned '{action}' into a reason to celebrate.");
                break;
        }
    }
}
