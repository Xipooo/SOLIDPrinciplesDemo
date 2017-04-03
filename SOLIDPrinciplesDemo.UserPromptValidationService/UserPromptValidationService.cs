using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.UserPromptValidationService
{
    public interface UserPromptValidationService
    {
        ValidationResult ValidateEntry(string UserEntry, List<UserPromptEntryRule> EntryRules);
    }
}
