using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class AcceptedYearLengthVehicleValidationRule : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public AcceptedYearLengthVehicleValidationRule(string VehicleYear, int AcceptedNumberOfDigits, string FailureMessage)
        {
            Result = new AcceptedYearLengthVehicleValidationResult(
                    VehicleYear.Length == AcceptedNumberOfDigits,
                    VehicleYear.Length == AcceptedNumberOfDigits ? null : FailureMessage
                );
        }
    }
}
