using SOLIDPrinciplesDemo.Solution.Features.Common;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    interface IVehicleValidationRules
    {
        List<Func<IVehicle, IValidationResult>> GetRuleList();
    }
}
