using System;

namespace JournalAppNotYourDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Your Journal! If this isn't your journal, please back up from the computer and leave before things get ugly!");
                Console.WriteLine("1. View Journal");
                Console.WriteLine("2. Add New Entry");
                Console.WriteLine("3. Save Journal");
                Console.WriteLine("4. Load Journal");
                Console.WriteLine("5. Exit");
                Console.Write("Please, select an option (1-5): ");
                
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    journal.DisplayJournal();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    string randomQuestion = journal.GetRandomQuestion();
                    Console.WriteLine($"Today's question: {randomQuestion}");

                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry(randomQuestion, response);
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Your entry has been added!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter the file name to save the journal (e.g., journal.txt): ");
                    string fileName = Console.ReadLine();

                    journal.SaveJournalToFile(fileName);
                    Console.WriteLine("Your journal was saved!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "4")
                {
                    Console.Write("Enter the file name to load the journal (e.g., journal.txt): ");
                    string fileName = Console.ReadLine();

                    journal.LoadJournalFromFile(fileName);
                    journal.DisplayJournal(); // Show the loaded entries
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("See you later then!");
                    break;
                }
                else
                {
                    Console.WriteLine("Erh! Invalid choice. Please select a valid option.");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                }
            }
        }
    }
}
