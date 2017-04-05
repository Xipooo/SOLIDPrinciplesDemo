using SOLIDPrinciplesDemo.UserPromptService;
using System;

namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    class SOLIDConsolePromptServiceProxy : ConsolePromptServiceProxy
    {
        private ConsolePostService _writeLinePromptService { get; }
        private ConsolePromptService<ConsoleKey> _readKeyPromptService { get; }
        private ConsolePromptService<string> _readLinePromptService { get; }

        public SOLIDConsolePromptServiceProxy(
            ConsolePromptService<ConsoleKey> ReadKeyPromptService,
            ConsolePromptService<string> ReadLinePromptService,
            ConsolePostService WriteLinePromptService)
        {
            _readKeyPromptService = ReadKeyPromptService;
            _readLinePromptService = ReadLinePromptService;
            _writeLinePromptService = WriteLinePromptService;
        }
        public ConsoleKey GetKeyFromUser(string PromptText) => _readKeyPromptService.GetAnswer(PromptText);
        public string GetStringFromUser(string PromptText) => _readLinePromptService.GetAnswer(PromptText);
        public void PostMessageToUser(string MessageText) => _writeLinePromptService.PostMessage(MessageText);
    }
}
