class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding your breathing.") { }

    public override void Start()  // 🔥 Now correctly overrides Start()
    {
        base.Start();
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowProgressBar(3);
            Console.WriteLine("Breathe out...");
            ShowProgressBar(3);
        }
        End();
    }
}
