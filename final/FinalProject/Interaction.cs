using System;

public class Interaction
{
    private RoommateManager roommateManager;

    public Interaction(RoommateManager manager)
    {
        roommateManager = manager;
    }

    public void Start()
    {
        Console.WriteLine("Roommate Info:");
        roommateManager.ShowInfo();

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("\nEnter an action (e.g., 'cleaning', 'party', 'cooking', 'laundry', 'grocery shopping', 'fixing things', 'trash', 'music', 'church', 'family home evening'): ");
            string action = Console.ReadLine().ToLower();

            Console.WriteLine("\nRoommates react to the '{0}' chore:", action);
            roommateManager.ReactToAction(action);

            Console.WriteLine("\nDo you want to enter another action? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response == "no")
            {
                keepGoing = false;
                Console.WriteLine("\nYour roommates are sad you are leaving...");
            }
            else if (response != "yes")
            {
                Console.WriteLine("\nInvalid input. Exiting...");
                keepGoing = false;
            }
        }
    }
}
