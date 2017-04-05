using SOLIDPrinciplesDemo.Common;
using SOLIDPrinciplesDemo.Refactored.Features.MainAction.ValidationRules;
using SOLIDPrinciplesDemo.VehicleValidationService;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciplesDemo.Refactored.Features.MainAction
{
    class ValidationRulesContainer
    {
        private List<VehicleValidationRule> _validationRules = new List<VehicleValidationRule>();

        public List<VehicleValidationRule> VehicleValidationRules(GetVehicleDetailsResult Vehicle) =>
            _validationRules
                .Concat(GeneralValidationRules(Vehicle))
                .Concat(AcceptedMakeRule(Vehicle))
                .Concat(AcceptedVehiclesRule(Vehicle)).ToList();

        private List<VehicleValidationRule> GeneralValidationRules(GetVehicleDetailsResult Vehicle) =>
            new List<VehicleValidationRule> {
            new YearIsNumericVehicleValidationRule(Vehicle.CarYear, "The year is not numeric."),
                    new VehicleValidationAnyRulesGroup(
                        new List<VehicleValidationRule>
                            {
                                new AcceptedYearLengthVehicleValidationRule(Vehicle.CarYear, 2, null),
                                new AcceptedYearLengthVehicleValidationRule(Vehicle.CarYear, 4, null)
                            }, "Vehicle year must be 2 or 4 digits in length.") };

        private List<VehicleValidationRule> AcceptedMakeRule(GetVehicleDetailsResult Vehicle) =>
            new List<VehicleValidationRule>
            {
                new AcceptedMakeValidationRule(
                            new SOLIDVehicle { Make = Vehicle.CarMake, Year = int.Parse(Vehicle.CarYear) },
                            new List<string> { "Mazda", "Toyota" },
                            "The car make you enetered is not currently being accepted.")
            };

        private List<VehicleValidationRule> AcceptedVehiclesRule(GetVehicleDetailsResult Vehicle) =>
            new List<VehicleValidationRule>
            {
                new VehicleValidationAnyRulesGroup(
                    new List<VehicleValidationRule>
                    {
                        AcceptedMazdasRule(Vehicle),
                        AcceptedToyotasRule(Vehicle)
                    }, )
            };

        private VehicleValidationAllRulesGroup AcceptedMazdasRule(GetVehicleDetailsResult Vehicle) =>
                new VehicleValidationAllRulesGroup(new List<VehicleValidationRule>
                {
                    new AcceptedMakeValidationRule(
                            new SOLIDVehicle { Make = Vehicle.CarMake, Year = int.Parse(Vehicle.CarYear) },
                            new List<string> { "Mazda" },
                            "The car make you enetered is not currently being accepted.")
                });
            
    }
}
