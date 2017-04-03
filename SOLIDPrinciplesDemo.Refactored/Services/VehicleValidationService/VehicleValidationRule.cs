using SOLIDPrinciplesDemo.Refactored.Services.Shared;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService
{
    interface VehicleValidationRule
    {
        bool Successful { get;}
        string FailureReason { get; }
        Vehicle Vehicle { get; }
    }
}
