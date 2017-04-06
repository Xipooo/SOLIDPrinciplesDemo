using System;

namespace SOLIDPrinciplesDemo.Solution.Features.ConsoleUI
{
    public class ConsoleUIOrchestrator : IConsoleUIOrchestrator
    {
        public string GetVehicleMake() {
            Console.WriteLine(Environment.NewLine + "Please enter the make of the car:");
            return Console.ReadLine();
        }

        public string GetVehicleYear()
        {
            Console.WriteLine("Please enter the year of the car:");
            return Console.ReadLine();
        }
    }
}
