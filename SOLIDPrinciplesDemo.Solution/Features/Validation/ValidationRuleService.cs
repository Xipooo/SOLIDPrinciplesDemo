using System;

namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    class ValidationRuleService : IValidationRuleService
    {
        public IValidationResult Validate<T>(T Value, Func<T, IValidationResult> Rule)
        {
            return Rule(Value);
        }
    }
}
