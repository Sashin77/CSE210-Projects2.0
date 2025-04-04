using System;

public class Program
{
    public static void Main(string[] args)
    {
        RoommateManager roommateManager = new RoommateManager();
        Interaction interaction = new Interaction(roommateManager);
        interaction.Start();
    }
}
