using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public class DTOVehicleValidationResult : ValidationResult
    {
        public string FailureReason { get; set; }
        public bool Successful { get; set; }
    }
}
