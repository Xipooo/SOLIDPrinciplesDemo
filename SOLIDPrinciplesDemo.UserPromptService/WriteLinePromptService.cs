using System;

namespace SOLIDPrinciplesDemo.UserPromptService
{
    public class WriteLinePromptService : ConsolePostService
    {
        public void PostMessage(string MessageText)
        {
            Console.WriteLine(MessageText);
        }
    }
}
