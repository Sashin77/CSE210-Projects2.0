using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of times when you helped someone.",
        "Recall moments when you showed resilience.",
        "List things you are grateful for today.",
        "Write down experiences that made you smile recently."
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect by listing out thoughts on a given prompt.") {}

    public void StartListing()
    {
        base.Start();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowProgressBar(3);

        Console.WriteLine("Feel free to start listing your responses:");
        int count = CollectResponses();
        
        Console.WriteLine($"Well done! You listed {count} items.");
        base.End();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private int CollectResponses()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }
        return responses.Count;
    }
}
