namespace SOLIDPrinciplesDemo.UserPromptService
{
    public interface ConsolePromptService<T>
    {
        T GetAnswer(string Question);
    }
}
