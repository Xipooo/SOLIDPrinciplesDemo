using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class VehicleValidationAllRulesGroup : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public VehicleValidationAllRulesGroup(List<VehicleValidationRule> VehicleValidationRules)
        {
            Result = new VehicleValidationAllRulesGroupResult(
                VehicleValidationRules.All(r => r.Result.Successful),
                VehicleValidationRules.FirstOrDefault(r => !r.Result.Successful)?.Result?.FailureReason);
        }
    }
}
