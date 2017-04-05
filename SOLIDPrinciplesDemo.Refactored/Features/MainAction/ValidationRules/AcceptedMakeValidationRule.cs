using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class AcceptedMakeValidationRule : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public AcceptedMakeValidationRule(Vehicle Vehicle, List<string> AcceptedMakes, string FailureMessage)
        {
            Result = new AcceptedMakeValidationResult(
                    AcceptedMakes.Any(m => m.ToLower() == Vehicle.Make.ToLower()),
                    AcceptedMakes.Any(m => m.ToLower() == Vehicle.Make.ToLower()) ? null : FailureMessage
                );
        }
    }
}
