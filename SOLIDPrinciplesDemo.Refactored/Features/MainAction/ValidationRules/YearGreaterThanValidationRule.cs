using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    public class YearGreaterThanValidationRule : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public YearGreaterThanValidationRule(Vehicle Vehicle, int LeastAcceptableYear, string FailureMessage)
        {
            Result = new YearGreaterThanValidationResult(
                Vehicle.Year >= LeastAcceptableYear,
                Vehicle.Year >= LeastAcceptableYear ? null : FailureMessage
            );
        }
    }
}
