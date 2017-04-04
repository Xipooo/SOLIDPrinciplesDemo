using System;
using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.Refactored.Services.UserPrompt;
using SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    class SOLIDMainOrchestrator : MainOrchestrator
    {
        private ConsolePromptServiceProxy _consolePromptService { get; }
        private VehicleValidationServiceProxy _vehicleValidationService { get; }
        public SOLIDMainOrchestrator(ConsolePromptServiceProxy ConsolePromptServiceProxy, VehicleValidationServiceProxy VehicleValidationServiceProxy)
        {
            _consolePromptService = ConsolePromptServiceProxy;
            _vehicleValidationService = VehicleValidationServiceProxy;
        }

        private GetVehicleDetailsResult GetVehicleDetails()
        {
            return new VehicleDetails(
                _consolePromptService.GetStringFromUser("Please enter the make of the car:"),
                _consolePromptService.GetStringFromUser("Please enter the year of the car:"));
        }

        private ValidationResult ValidateVehicle(GetVehicleDetailsResult Vehicle)
        {
            return _vehicleValidationService.ValidateVehicleThreadSafe(
                 new List<VehicleValidationService.VehicleValidationRule>
                 {
                    new YearIsNumericVehicleValidationRule(Vehicle.CarYear),
                 });
        }

        private 

        public void RunVehicleValidation()
        {
            
        }
    }
}
