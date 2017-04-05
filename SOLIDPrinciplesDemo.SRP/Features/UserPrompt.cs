using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.SRP.Features
{
    class UserPrompt
    {
        void AskCarMake() => Console.WriteLine(Environment.NewLine + "Please enter the make of the car:");
        void AskCarYear() => Console.WriteLine("Please enter the year of the car:");
        string GetRespose() => Console.ReadLine();
    }
}
