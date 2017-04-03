using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public abstract class VehicleValidationService
    {
        public ValidationResult Result { get; }
        public VehicleValidationService(List<VehicleValidationRule> VehicleValidationRules) { }
    }
}
