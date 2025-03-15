class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int targetCount;
    private int bonus;

    public ChecklistGoal(string name, int points, int targetCount, int bonus) : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (timesCompleted < targetCount)
        {
            timesCompleted++;
            return timesCompleted == targetCount ? points + bonus : points;
        }
        return 0;
    }

    public override bool IsComplete() => timesCompleted >= targetCount;
    public override string Display() => $"{(IsComplete() ? "[X]" : "[ ]")} {name} - {timesCompleted}/{targetCount} times";
    public override string Save() => $"Checklist|{name}|{points}|{timesCompleted}|{targetCount}|{bonus}";
}
