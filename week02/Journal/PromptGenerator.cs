using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "What was the best part of my day?",
            "What is something new I learned today?",
            "What could I do better tomorrow?",
            "What am I grateful for right now?",
            "How reading my scriptures helped me today?",
            "What is something I could do today that will help me tomorrow?",
            "What was the strongest emotion I felt today?",
        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}