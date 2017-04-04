using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    static class ProgramExtensions
    {
        static GetVehicleDetailsResult GetVehicleDetails(this Program me)
        {
            return new VehicleDetails(
                me.ConsolePromptService.GetStringFromUser("Please enter the make of the car:"),
                me.ConsolePromptService.GetStringFromUser("Please enter the year of the car:"));
        }

        static ValidationResult ValidateVehicle(this Program me, GetVehicleDetailsResult Vehicle)
        {
            return me.VehicleValidationService.ValidateVehicleThreadSafe(
                new List<VehicleValidationService.VehicleValidationRule>
                {
                    new YearIsNumericVehicleValidationRule(Vehicle.CarYear)
                });
        }
    }
}
