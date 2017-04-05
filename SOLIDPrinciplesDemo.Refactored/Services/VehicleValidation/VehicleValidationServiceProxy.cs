using System.Collections.Generic;
using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation
{
    public interface VehicleValidationServiceProxy
    {
        ValidationResult ValidateVehicle(List<VehicleValidationRule> ValidationRules);
    }
}