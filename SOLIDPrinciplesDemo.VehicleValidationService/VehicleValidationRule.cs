using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.VehicleValidationService
{
    public interface VehicleValidationRule
    {
        ValidationResult Result { get; }
    }
}
