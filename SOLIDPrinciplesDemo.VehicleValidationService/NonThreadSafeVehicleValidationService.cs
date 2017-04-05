using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public class NonThreadSafeVehicleValidationService : VehicleValidationService
    {
        public ValidationResult ValidateRules(List<VehicleValidationRule> VehicleValidationRules)
        {
            return new DTOVehicleValidationResult
            {
                Successful = VehicleValidationRules.All(r => r.Result.Successful),
                FailureReason = VehicleValidationRules.FirstOrDefault(r => !r.Result.Successful)?.Result?.FailureReason
            };
        }
    }
}
