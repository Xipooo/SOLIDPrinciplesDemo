using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class YearLessThanValidationResult : ValidationResult
    {
        public string FailureReason { get; }

        public bool Successful { get; }

        public YearLessThanValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
