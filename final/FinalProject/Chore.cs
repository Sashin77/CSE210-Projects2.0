public abstract class Chore
{
    public string Name { get; set; }

    protected Chore(string name)
    {
        Name = name;
    }

    public abstract void Perform(Roommate roommate);
}
