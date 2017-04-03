using System;

namespace SOLIDPrinciplesDemo.UserPromptService
{
    public class ReadKeyPromptService : ConsolePromptService<ConsoleKey>
    {
        public ConsoleKey GetAnswer(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadKey().Key;
        }
    }
}
