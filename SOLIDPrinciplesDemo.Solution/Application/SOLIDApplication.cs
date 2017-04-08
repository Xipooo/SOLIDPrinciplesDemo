using SOLIDPrinciplesDemo.Solution.Features.Common;
using System;

namespace SOLIDPrinciplesDemo.Solution.Application
{
    class SOLIDApplication : IApplication
    {
        private readonly ISOLIDApplicationOrchestrator _orchestrator;
        private readonly IVehicle _vehicle;

        public SOLIDApplication(ISOLIDApplicationOrchestrator orchestrator, IVehicle vehicle)
        {
            _orchestrator = orchestrator;
            _vehicle = vehicle;
        }
        public void Run()
        {
            bool exitApp = false;
            while (!exitApp)
            {
                _vehicle.VehicleMake = _orchestrator.GetVehicleMake();
                _vehicle.VehicleYear = _orchestrator.GetVehicleYear();

                var validationResult = _orchestrator.ValidateVehicle(_vehicle);
                _orchestrator.PostMessage(validationResult.Successful ? "Congratulations!  Your car has been accepted!" : validationResult.ErrorMessage);

                Console.WriteLine("Would you like to try another car? (Y/N)");
                exitApp = (Console.ReadKey().Key != ConsoleKey.Y);
            }
        }
    }
}
