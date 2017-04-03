using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation
{
    class SOLIDVehicleValidationServiceProxy : VehicleValidationServiceProxy
    {
        public ValidationResult ValidateVehicleThreadSafe(List<VehicleValidationRule> ValidationRules) => 
            new ThreadSafeVehicleValidationService().ValidateVehicle(ValidationRules);

        public ValidationResult ValidatieVehicleNonThreadSafe(List<VehicleValidationRule> ValidationRules) =>
            new NonThreadSafeVehicleValidationService().ValidateVehicle(ValidationRules);

        public ValidationResult ValidateVehicle(
            VehicleValidationService.VehicleValidationService VehicleValidationService,
            List<VehicleValidationRule> ValidationRules) =>
            VehicleValidationService.ValidateVehicle(ValidationRules);
    }
}
