using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class VehicleValidationAllRulesGroupResult : ValidationResult
    {
        public string FailureReason { get; }
        public bool Successful { get; }

        public VehicleValidationAllRulesGroupResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
