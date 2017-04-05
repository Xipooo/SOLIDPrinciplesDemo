using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class AcceptedYearLengthVehicleValidationResult : ValidationResult
    {
        public string FailureReason { get; }

        public bool Successful { get; }

        public AcceptedYearLengthVehicleValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
