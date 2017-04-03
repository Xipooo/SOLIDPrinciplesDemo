using SOLIDPrinciplesDemo.Refactored.Services.Shared;
using SOLIDPrinciplesDemo.Refactored.Services.VehicleValidationService;
using System;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAPI
{
    class MainInterface : MainAPI
    {
        public GetVehicleDetailsResult GetVehicleDetails()
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidateVehicle(GetVehicleDetailsResult Vehicle)
        {
            var validationRules = new 
        }

        public void WriteResult(ValidationResult ValidationResult)
        {
            throw new NotImplementedException();
        }
    }
}
