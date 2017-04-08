using System;

namespace SOLIDPrinciplesDemo.Solution.Features.UserPrompt
{
    class UserPromptService : IUserPromptService
    {
        public string GetUserInput(string MessageText)
        {
            Console.WriteLine(MessageText);
            return Console.ReadLine();
        }
        public ConsoleKey GetUserKey(string MessageText)
        {
            Console.WriteLine(MessageText);
            return Console.ReadKey().Key;
        }
        public void PostMessage(string MessageText) => Console.WriteLine(MessageText);
    }
}
