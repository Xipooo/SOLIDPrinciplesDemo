using SOLIDPrinciplesDemo.Refactored.Services.Shared;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService
{
    class SOLIDVehicleValidationService : VehicleValidationService
    {
        public ValidationResult ValidateVehicle(List<VehicleValidationRule> VehicleValidationRules)
        {
            return new DIVehicleValidationResult(VehicleValidationRules.All(r => r.Successful), VehicleValidationRules.FirstOrDefault(r => !r.Successful)?.FailureReason);
        }
    }
}
