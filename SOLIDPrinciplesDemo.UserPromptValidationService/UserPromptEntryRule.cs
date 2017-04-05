using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.UserPromptValidationService
{
    public interface UserPromptEntryRule
    {
        ValidationResult Result { get; }
    }
}
