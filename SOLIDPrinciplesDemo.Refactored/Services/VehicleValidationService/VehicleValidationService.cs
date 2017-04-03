using SOLIDPrinciplesDemo.Refactored.Services.Shared;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService
{
    interface VehicleValidationService
    {
        ValidationResult ValidateVehicle(List<VehicleValidationRule> VehicleValidationRules);
    }
}
