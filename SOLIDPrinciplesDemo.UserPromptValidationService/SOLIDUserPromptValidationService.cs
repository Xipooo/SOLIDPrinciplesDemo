using SOLIDPrinciplesDemo.Common;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.UserPromptValidationService
{
    class SOLIDUserPromptValidationService : UserPromptValidationService
    {
        public ValidationResult ValidateEntry(string UserEntry, List<UserPromptEntryRule> EntryRules)
        {
            return new UserPromptValidationResult(
                EntryRules.All(r => r.Result.Successful),
                EntryRules.FirstOrDefault(r => !r.Result.Successful).Result.FailureReason);
        }
    }
}
