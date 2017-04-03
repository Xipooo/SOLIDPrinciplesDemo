using System;

namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    class ReadKeyPromptService : ConsolePromptService<ConsoleKey>
    {
        public ConsoleKey GetAnswer(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadKey().Key;
        }
    }
}
