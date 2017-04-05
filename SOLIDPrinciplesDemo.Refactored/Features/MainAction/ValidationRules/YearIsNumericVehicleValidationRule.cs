using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules
{
    class YearIsNumericVehicleValidationRule : VehicleValidationRule
    {
        public ValidationResult Result { get; }

        public YearIsNumericVehicleValidationRule(string VehicleYear, string ValidationMessage)
        {
            var intParseResult = int.TryParse(VehicleYear, out int newYear);
            Result =  new DIVehicleValidationResult(intParseResult, (intParseResult ? null : ValidationMessage));
        }
    }
}
