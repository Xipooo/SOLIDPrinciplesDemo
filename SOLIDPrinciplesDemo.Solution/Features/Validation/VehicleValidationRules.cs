using SOLIDPrinciplesDemo.Solution.Features.Common;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciplesDemo.Solution.Features.Validation
{
    class VehicleValidationRules : IVehicleValidationRules
    {
        private readonly IValidationRuleService _validationRuleService;
        private readonly IValidationResult _validationResult;

        public VehicleValidationRules(IValidationRuleService validationRuleService, IValidationResult validationResult)
        {
            _validationRuleService = validationRuleService;
            _validationResult = validationResult;
        }

        public List<Func<IValidationResult>> GetRuleList(IVehicle vehicle) => new List<Func<IValidationResult>>
        {
            () => _validationRuleService.Validate(vehicle.VehicleYear,
                y =>
                {
                    _validationResult.Successful = int.TryParse(y, out int intResult);
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Year entered is not a number.";
                    return _validationResult;
                }),

            () => _validationRuleService.Validate(vehicle.VehicleYear,
                r =>
                {
                    _validationResult.Successful = r.Length == 2 || r.Length == 4;
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Year of the car entered must be 2 or 4 digits.";
                    return _validationResult;
                })
        };
    }
}
