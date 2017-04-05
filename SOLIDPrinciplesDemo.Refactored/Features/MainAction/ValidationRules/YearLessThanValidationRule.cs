using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class YearLessThanValidationRule : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public YearLessThanValidationRule(Vehicle Vehicle, int HighestAcceptableYear, string FailureMessage)
        {
            Result = new YearLessThanValidationResult(
                Vehicle.Year <= HighestAcceptableYear,
                Vehicle.Year <= HighestAcceptableYear ? null : FailureMessage
            );
        }
    }
}
