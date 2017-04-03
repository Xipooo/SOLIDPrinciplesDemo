using SOLIDPrinciplesDemo.Refactored.Services.Shared;
using SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAPI
{
    class YearIsNumericVehicleValidationRule : VehicleValidationRule
    {
        public bool Successful { get; }

        public string FailureReason { get; }

        public Vehicle Vehicle { get; }

        public YearIsNumericVehicleValidationRule(string VehicleYear)
        {
            int newYear;
            Successful = int.TryParse(VehicleYear, out newYear);
            if (!Successful) FailureReason = "The year is not numeric.";
        }
    }
}
