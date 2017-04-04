using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;
using System.Linq;
using System;

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
