public static class UserAction
{
    public static Roommate PickRoommate(List<Roommate> roommates)
    {
        Console.WriteLine("Choose a roommate:");
        for (int i = 0; i < roommates.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {roommates[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        return roommates[choice];
    }
}
