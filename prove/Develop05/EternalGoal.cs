class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent() => points;
    public override bool IsComplete() => false;
    public override string Display() => $"[∞] {name} - {points} points each time";
    public override string Save() => $"Eternal|{name}|{points}";
}
