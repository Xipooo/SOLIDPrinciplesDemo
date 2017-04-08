using System;

namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    public interface IValidationRuleService
    {
        IValidationResult Validate<T>(T Value, Func<T, IValidationResult> Rule);
    }
}
