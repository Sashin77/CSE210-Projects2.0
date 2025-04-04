public class CleanRoomChore : Chore
{
    public CleanRoomChore() : base("Clean your room") { }

    public override void Perform(Roommate roommate)
    {
        Console.WriteLine($"{roommate.Name} is told to clean their room...");
        roommate.ReactToAction("clean_room");
    }
}
