using System;
using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    class YearIsNumericVehicleValidationRule : VehicleValidationRule
    {
        public bool Successful { get; }

        public string FailureReason { get; }

        public Vehicle Vehicle { get; }

        public YearIsNumericVehicleValidationRule(string VehicleYear)
        {
            Successful = int.TryParse(VehicleYear, out int newYear);
            if (!Successful) FailureReason = "The year is not numeric.";
        }

        public ValidationResult ValidateVehicleRule(Vehicle Vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
