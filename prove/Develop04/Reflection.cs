using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think about a time when you sacrificed something for someone else.",
        "Reflect on a moment where you were pushed out of your comfort zone and forced to evolve.",
        "Remember a time when you felt truly grateful for something."
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on meaningful experiences.") { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine(GetRandomPrompt());
        ShowProgressBar(Duration);
        End();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
