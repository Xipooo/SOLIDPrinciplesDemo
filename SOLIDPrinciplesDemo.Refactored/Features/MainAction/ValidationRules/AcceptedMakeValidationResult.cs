using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class AcceptedMakeValidationResult : ValidationResult
    {
        public string FailureReason { get; }
        public bool Successful { get; }

        public AcceptedMakeValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
