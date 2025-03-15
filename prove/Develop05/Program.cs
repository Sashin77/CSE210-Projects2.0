using System;

class Program
{
    static void Main()
    {
        QuestManager questManager = new QuestManager();
        questManager.LoadProgress();

        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    questManager.CreateGoal();
                    break;
                case "2":
                    questManager.RecordEvent();
                    break;
                case "3":
                    questManager.ShowGoals();
                    break;
                case "4":
                    questManager.SaveProgress();
                    break;
                case "5":
                    questManager.SaveProgress();
                    Console.WriteLine("Your legendary journey is saved. Farewell, hero!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
