using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Refactored.Services.VehicleValidation
{
    class SOLIDVehicleValidationServiceProxy : VehicleValidationServiceProxy
    {
        private VehicleValidationService.VehicleValidationService _vehicleValidationService { get; }

        public SOLIDVehicleValidationServiceProxy(VehicleValidationService.VehicleValidationService VehicleValidationService)
        {
            _vehicleValidationService = VehicleValidationService;
        }

        public ValidationResult ValidateVehicle(List<VehicleValidationRule> ValidationRules) =>
            _vehicleValidationService.ValidateRules(ValidationRules);
    }
}
