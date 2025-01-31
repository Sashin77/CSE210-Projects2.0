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

    public void UpdateEntry(string newQuestion, string newResponse)
    {
        Question = newQuestion;
        The_Response = newResponse;
    }

    public override string ToString()
    {
        return $"{The_Date} - {Question}\n{The_Response}";
    }
}
