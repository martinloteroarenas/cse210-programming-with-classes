public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?"
    };

    public string GetRandomPrompt()
    {
        Random RandomGenerator = new Random();
        int randomIndex = RandomGenerator.Next(_prompts.Count);
        string RandomPrompt = _prompts[randomIndex];
        return RandomPrompt;
    }
}