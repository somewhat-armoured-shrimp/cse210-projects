public class PromptGenerator
{  
    public List<string> _prompts = new List<string>(new string[]
    {"Who was the most boring person that I interacted with today, and why? ",
    "What was the best part of today? ", "What happened today that you thought was interesting? ", "What was a notable thing my cat did today? ", "What did the skinned man tell you today? "});

    public string GetRandomPrompt()
    {
        // random
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        return _prompts[index];
    }
}