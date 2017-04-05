using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class VehicleValidationAnyRulesGroup : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public VehicleValidationAnyRulesGroup(List<VehicleValidationRule> VehicleValidationRules, string FailureReason)
        {
            Result = new VehicleValidationAnyRulesGroupResult(
                VehicleValidationRules.Any(r => r.Result.Successful),
                VehicleValidationRules.Any(r => r.Result.Successful) ? null : FailureReason);
        }
    }
}
