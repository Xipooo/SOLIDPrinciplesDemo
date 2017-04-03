using SOLIDPrinciplesDemo.Refactored.Services.Shared;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService
{
    class DTOVehicleValidationResult : ValidationResult
    {
        public string FailureReason { get; set; }
        public bool Successful { get; set; }
    }
}
