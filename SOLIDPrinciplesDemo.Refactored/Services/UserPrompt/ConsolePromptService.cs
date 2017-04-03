namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    interface ConsolePromptService<T>
    {
        T GetAnswer(string Question);
    }
}
