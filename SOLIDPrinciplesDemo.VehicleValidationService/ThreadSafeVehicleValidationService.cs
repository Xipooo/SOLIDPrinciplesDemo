using SOLIDPrinciplesDemo.Common;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public class ThreadSafeVehicleValidationService : VehicleValidationService
    {

        public ValidationResult ValidateRules(List<VehicleValidationRule> VehicleValidationRules)
        {
            throw new NotImplementedException();
        }

    }
}
