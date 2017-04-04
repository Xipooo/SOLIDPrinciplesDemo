using SOLIDPrinciplesDemo.UserPromptService;
using System;

namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    class SOLIDConsolePromptServiceProxy : ConsolePromptServiceProxy
    {
        public ConsoleKey GetKeyFromUser(string PromptText) => new ReadKeyPromptService().GetAnswer(PromptText);
        public string GetStringFromUser(string PromptText) => new ReadLinePromptService().GetAnswer(PromptText);

        public void PostMessageToUser(string MessageText) => new WriteLinePromptService().PostMessage(MessageText);
    }
}
