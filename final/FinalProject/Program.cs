using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Roommate roommate1 = new Roommate("Alice", "friendly", new string[] { "cooking", "cleaning" });
        MessyRoommate messyRoommate = new MessyRoommate("Bob", "lazy", new string[] { "watching TV", "eating chips" }, true);
        ResponsibleRoommate responsibleRoommate = new ResponsibleRoommate("Charlie", "organized", new string[] { "budgeting", "scheduling" }, true);

        
        Console.WriteLine("Introducing roommates...\n");
        
        roommate1.Introduce();
        roommate1.DoChores();
        Console.WriteLine();

        messyRoommate.Introduce();
        messyRoommate.ShowMessiness();
        messyRoommate.DoChores();
        Console.WriteLine();

        responsibleRoommate.Introduce();
        responsibleRoommate.ShowResponsibility();
        responsibleRoommate.DoChores();
    }
}
