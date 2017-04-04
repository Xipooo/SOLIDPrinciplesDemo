using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public interface VehicleValidationService
    {
        ValidationResult ValidateRules(List<VehicleValidationRule> VehicleValidationRules);
    }
}
