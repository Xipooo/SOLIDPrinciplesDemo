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

        public List<Func<IVehicle, IValidationResult>> GetRuleList() => new List<Func<IVehicle, IValidationResult>>
        {
            (v) => _validationRuleService.Validate(v.VehicleYear,
                r =>
                {
                    _validationResult.Successful = int.TryParse(r, out int intResult);
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Year entered is not a number.";
                    return _validationResult;
                }),

            (v) => _validationRuleService.Validate(v.VehicleYear,
                r =>
                {
                    _validationResult.Successful = r.Length == 2 || r.Length == 4;
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Year of the car entered must be 2 or 4 digits.";
                    return _validationResult;
                }),

            (v) => _validationRuleService.Validate(v,

                r =>
                {
                    _validationResult.Successful =
                    (r.VehicleMake.ToLower() != "mazda")
                    || ((r.VehicleYear.Length == 2 && (int.Parse(r.VehicleYear) >= 97 || (int.Parse(r.VehicleYear) <= int.Parse(DateTime.Now.AddYears(1).ToString("yy"))))
                    || (r.VehicleYear.Length == 4 && int.Parse(r.VehicleYear) >= 1997)));
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Your car is too old!";
                    return _validationResult;
                }),

            (v) => _validationRuleService.Validate(v,
                r =>
                {
                    _validationResult.Successful =
                    (r.VehicleMake.ToLower() != "toyota")
                    || (r.VehicleYear.Length == 2 && (int.Parse(r.VehicleYear) <= 6 || int.Parse(r.VehicleYear) >= 99))
                    || (r.VehicleYear.Length == 4 && int.Parse(r.VehicleYear) >= 1999);
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "Your car is not with the years we are accepting.";
                    return _validationResult;
                }),
            (v) => _validationRuleService.Validate(v,
                r =>
                {
                    _validationResult.Successful =
                    (r.VehicleMake.ToLower() == "toyota" || r.VehicleMake.ToLower() == "mazda");
                    _validationResult.ErrorMessage = _validationResult.Successful ? null : "The car make you enetered is not currently being accepted.";
                    return _validationResult;
                })
        };
    }
}
