class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        completed = false;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return points;
        }
        return 0;
    }

    public override bool IsComplete() => completed;
    public override string Display() => $"{(completed ? "[X]" : "[ ]")} {name} - {points} points";
    public override string Save() => $"Simple|{name}|{points}|{completed}";
}
