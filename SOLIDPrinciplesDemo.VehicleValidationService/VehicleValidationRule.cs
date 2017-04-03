using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public abstract class VehicleValidationRule
    {
        public ValidationResult Result { get; }
        public VehicleValidationRule(Vehicle Vehicle) { }
    }
}
