using System;
using System.Collections.Generic;
using System.IO;

namespace JournalAppNotYourDiary
{
    public class Journal
    {
        private List<Entry> entries;
        private List<string> questions;

        public Journal()
        {
            entries = new List<Entry>();
            questions = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        }

        public void AddEntry(Entry newEntry)
        {
            entries.Add(newEntry);
        }

        public void DisplayJournal()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("Pardon our dust, but your journal is empty.");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }

        public void SaveJournalToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.The_Date};{entry.Question};{entry.The_Response}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadJournalFromFile(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            try
            {
                var lines = File.ReadAllLines(path);
                if (lines.Length == 0)
                {
                    Console.WriteLine("The journal file is empty.");
                }

                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        var date = parts[0];
                        var question = parts[1];
                        var response = parts[2];

                        var entry = new Entry(question, response)
                        {
                            The_Date = date
                        };
                        entries.Add(entry);
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, but we ran into a bump opening this journal. " + e.Message);
            }
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            return questions[index];
        }
    }

    public class Entry
    {
        public string The_Date { get; set; }
        public string Question { get; set; }
        public string The_Response { get; set; }

        public Entry(string question, string response)
        {
            The_Date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            Question = question;
            The_Response = response;
        }

        public override string ToString()
        {
            return $"{The_Date} - {Question}\n{The_Response}";
        }
    }
}
