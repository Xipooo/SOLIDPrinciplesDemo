using System;

namespace SOLIDPrinciplesDemo.Solution.Features.UserPrompt
{
    public interface IUserPromptService
    {
        string GetUserInput(string MessageText);
        ConsoleKey GetUserKey(string MessageText);
        void PostMessage(string MessageText);
    }
}
