using SOLIDPrinciplesDemo.Solution.Features.Common;
using SOLIDPrinciplesDemo.Solution.Features.GetCarDetails;
using SOLIDPrinciplesDemo.Solution.Features.UserPrompt;
using SOLIDPrinciplesDemo.Solution.Features.Validation;
using System.Linq;

namespace SOLIDPrinciplesDemo.Solution.Application
{
    class SOLIDApplicationOrchestrator : ISOLIDApplicationOrchestrator
    {
        private readonly IGetCarDetailsOrchestrator _carDetailsOrchestrator;
        private readonly IValidationRuleService _validationRuleService;
        private readonly IValidationResult _validationResult;
        private readonly IUserPromptService _userPrompt;
        private readonly IVehicleValidationRules _vehicleValidationRules;

        public SOLIDApplicationOrchestrator(IGetCarDetailsOrchestrator carDetailsOrchestrator,
            IValidationRuleService validationRuleService,
            IValidationResult validationResult,
            IUserPromptService userPrompt,
            IVehicleValidationRules vehicleValidationRules)
        {
            _carDetailsOrchestrator = carDetailsOrchestrator;
            _validationRuleService = validationRuleService;
            _validationResult = validationResult;
            _userPrompt = userPrompt;
            _vehicleValidationRules = vehicleValidationRules;
        }

        public string GetVehicleMake() => _carDetailsOrchestrator.GetVehicleMake();
        public string GetVehicleYear() => _carDetailsOrchestrator.GetVehicleYear();
        public void PostMessage(string MessageText) => _userPrompt.PostMessage(MessageText);
        public IValidationResult ValidateVehicle(IVehicle vehicle) =>
            _vehicleValidationRules.GetRuleList().Any(r => !r(vehicle).Successful) ?
                 _vehicleValidationRules.GetRuleList().FirstOrDefault(r => !r(vehicle).Successful).Invoke(vehicle) :
                CreateSuccessfulResult();
        private IValidationResult CreateSuccessfulResult() { _validationResult.Successful = true; return _validationResult; }
    }
}
