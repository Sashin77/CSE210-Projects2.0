public class CleaningChore : Chore
{
    public CleaningChore() : base("Clean the living room") { }

    public override void Perform(Roommate roommate)
    {
        Console.WriteLine($"{roommate.Name} tries to clean...");
        roommate.ReactToAction("clean");
    }
}
