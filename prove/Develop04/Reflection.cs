using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think about a time when you faced a challenge and overcame it.",
        "Reflect on a moment when you showed kindness to someone.",
        "Remember a time when you felt truly grateful for something."
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on meaningful experiences.") { }

    public override void Start()  // 🔥 Now correctly overrides Start()
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
