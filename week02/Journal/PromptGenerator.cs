using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
       "Do believe that the Church of Jesus Christ of Latter-day Saints is the one true church?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What is a goal you want to achieve this week?",
        "Write about a memorable experience from your childhood."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}