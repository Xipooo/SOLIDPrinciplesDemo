using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public class NonThreadSafeVehicleValidationService : VehicleValidationService
    {
        public ValidationResult ValidateVehicle(List<VehicleValidationRule> VehicleValidationRules)
        {
            return new DTOVehicleValidationResult {
                Successful = VehicleValidationRules.All(r => r.Successful),
                FailureReason = VehicleValidationRules.FirstOrDefault(r => !r.Successful)?.FailureReason
            };
        }
    }
}
