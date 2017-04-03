using SOLIDPrinciplesDemo.Common;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    interface MainOrchestrator
    {
        GetVehicleDetailsResult GetVehicleDetails();
        ValidationResult ValidateVehicle(GetVehicleDetailsResult Vehicle);
        void WriteResult(ValidationResult ValidationResult);
    }
}
