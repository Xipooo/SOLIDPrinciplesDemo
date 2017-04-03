using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.UserPromptValidationService
{
    public abstract class UserPromptEntryRule
    {
        public ValidationResult Result { get; }

        public UserPromptEntryRule(string UserEntry) { }
    }
}
