using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    class DTOVehicleValidationResult : ValidationResult
    {
        public string FailureReason { get; set; }
        public bool Successful { get; set; }
    }
}
