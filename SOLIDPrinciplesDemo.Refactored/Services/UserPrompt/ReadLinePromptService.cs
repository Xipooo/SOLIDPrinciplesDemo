using System;

namespace SOLIDPrinciplesDemo.Refactored.Services.UserPrompt
{
    class ReadLinePromptService : ConsolePromptService<string>
    {
        public string GetAnswer(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadLine();
        }
    }
}
