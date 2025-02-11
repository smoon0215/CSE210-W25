using System;
using System.Collections.Generic;

public class Prompts{
    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "What am I grateful for?",
        "Who was the first person I said Hello to today?",
        "In what ways did I feel the Lord say I love you, and I see you today?"
    };

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}