﻿using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class VehicleValidationAnyRulesGroupResult : ValidationResult
    {
        public string FailureReason { get; }

        public bool Successful { get; }

        public VehicleValidationAnyRulesGroupResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }


    }
}