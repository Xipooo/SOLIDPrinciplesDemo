using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.Refactored.Services.UserPrompt;
using SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation;
using System;

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

        private GetVehicleDetailsResult GetVehicleDetails() =>
            new VehicleDetails(
                _consolePromptService.GetStringFromUser("Please enter the make of the car:"),
                _consolePromptService.GetStringFromUser("Please enter the year of the car:"));

        private ValidationResult ValidateVehicle(GetVehicleDetailsResult VehicleDetails) =>
            _vehicleValidationService.ValidateVehicle(new ValidationRulesContainer().VehicleValidationRules(VehicleDetails));

        private void DisplayValidationResult(ValidationResult ValidationResult) =>
            _consolePromptService.PostMessageToUser((ValidationResult.Successful ? "" : ValidationResult.FailureReason));

        public void RunVehicleValidation()
        {
            do
            {
                DisplayValidationResult(ValidateVehicle(GetVehicleDetails()));
            } while (_consolePromptService.GetKeyFromUser(@"Would you like to try another car? (Y/N)") == ConsoleKey.Y);
        }
    }
}
