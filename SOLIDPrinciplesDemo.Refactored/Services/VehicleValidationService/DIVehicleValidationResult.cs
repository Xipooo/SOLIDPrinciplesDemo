using SOLIDPrinciplesDemo.Refactored.Services.Shared;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService
{
    class DIVehicleValidationResult : ValidationResult
    {
        public string FailureReason { get; }
        public bool Successful { get; }

        public DIVehicleValidationResult(bool Successful, string FailureReason)
        {
            this.Successful = Successful;
            this.FailureReason = FailureReason;
        }
    }
}
