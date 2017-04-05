using System;

namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    public interface ConsolePromptServiceProxy
    {
        ConsoleKey GetKeyFromUser(string PromptText);
        string GetStringFromUser(string PromptText);
        void PostMessageToUser(string MessageText);
    }
}