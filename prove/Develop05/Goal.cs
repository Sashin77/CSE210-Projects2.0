using System;
using System.Collections.Generic;

abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string Display();
    public abstract string Save();
}
