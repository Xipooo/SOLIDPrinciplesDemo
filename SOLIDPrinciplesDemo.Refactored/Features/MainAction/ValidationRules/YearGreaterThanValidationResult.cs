using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class YearGreaterThanValidationResult : ValidationResult
    {
        public string FailureReason { get; }
        public bool Successful { get; }

        public YearGreaterThanValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
