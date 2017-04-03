using System.Collections.Generic;
using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation
{
    interface VehicleValidationServiceProxy
    {
        ValidationResult ValidateVehicle(VehicleValidationService.VehicleValidationService VehicleValidationService, List<VehicleValidationRule> ValidationRules);
        ValidationResult ValidateVehicleThreadSafe(List<VehicleValidationRule> ValidationRules);
        ValidationResult ValidatieVehicleNonThreadSafe(List<VehicleValidationRule> ValidationRules);
    }
}