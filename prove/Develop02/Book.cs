using System;

public class Book{
    public DateTime date {get; set; }
    public string Prompt {get; set; }
    public string EntryText {get; set; }

    public override string ToString()
    {
        return $"Date: {date.ToShortDateString()}\nPrompt: {Prompt}\nEntry: {EntryText}\n";
    }
}