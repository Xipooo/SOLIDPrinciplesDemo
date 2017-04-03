namespace SOLIDPrinciplesDemo.UserPromptService
{
    interface ConsolePromptService<T>
    {
        T GetAnswer(string Question);
    }
}
