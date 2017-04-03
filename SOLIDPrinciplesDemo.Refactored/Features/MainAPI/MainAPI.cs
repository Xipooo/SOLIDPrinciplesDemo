using SOLIDPrinciplesDemo.Refactored.Services.Shared;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAPI
{
    interface MainAPI
    {
        GetVehicleDetailsResult GetVehicleDetails();
        ValidationResult ValidateVehicle(GetVehicleDetailsResult Vehicle);
        void WriteResult(ValidationResult ValidationResult);
    }
}
