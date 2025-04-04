using System;
using System.Collections.Generic;

public class RoommateManager
{
    private List<Roommate> roommates;

    public RoommateManager()
    {
        roommates = new List<Roommate>
        {
            new NeatFreakRoommate("Sashin", new List<string> { "budgeting", "scheduling" }),
            new LazyRoommate("Cody", new List<string> { "watching TV", "eating chips" }),
            new PartyAnimalRoommate("Levi", new List<string> { "dancing", "hosting" }),
            new JudgyRoommate("Kakela", new List<string> { "planning", "cleaning" })
        };
    }

    public void ReactToAction(string action)
    {
        foreach (var roommate in roommates)
        {
            roommate.ReactToAction(action);
        }
    }

    public void ShowInfo()
    {
        foreach (var roommate in roommates)
        {
            roommate.ShowInfo();
        }
    }
}
