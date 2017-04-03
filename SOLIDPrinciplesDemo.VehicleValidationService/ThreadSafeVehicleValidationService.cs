using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public class ThreadSafeVehicleValidationService : VehicleValidationService
    {
        public ThreadSafeVehicleValidationService(List<VehicleValidationRule> VehicleValidationRules) : base(VehicleValidationRules)
        {
        }

        public ValidationResult ValidateVehicle(Vehicle Vehicle,List<VehicleValidationRule> VehicleValidationRules)
        {
            return new DIVehicleValidationResult(VehicleValidationRules.All(r => r.ValidateVehicleRule(Vehicle).Successful), VehicleValidationRules.FirstOrDefault(r => !r.Successful)?.FailureReason);
        }
    }
}
