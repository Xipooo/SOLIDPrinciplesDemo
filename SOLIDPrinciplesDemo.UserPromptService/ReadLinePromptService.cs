using System;

namespace SOLIDPrinciplesDemo.UserPromptService
{
    public class ReadLinePromptService : ConsolePromptService<string>
    {
        public string GetAnswer(string Question)
        {
            Console.WriteLine(Question);
            return Console.ReadLine();
        }
    }
}
