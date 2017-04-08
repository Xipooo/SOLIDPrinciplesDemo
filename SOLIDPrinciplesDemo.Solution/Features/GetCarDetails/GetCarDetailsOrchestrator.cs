using SOLIDPrinciplesDemo.Solution.Features.UserPrompt;
using System;

namespace SOLIDPrinciplesDemo.Solution.Features.GetCarDetails
{
    class GetCarDetailsOrchestrator : IGetCarDetailsOrchestrator
    {
        private readonly IUserPromptService _userPrompt;

        public GetCarDetailsOrchestrator(IUserPromptService UserPrompt)
        {
            _userPrompt = UserPrompt;
        }

        public string GetVehicleMake()
        {
            return _userPrompt.GetUserInput(Environment.NewLine + "Please enter the make of the car:");
        }
        public string GetVehicleYear()
        {
            return _userPrompt.GetUserInput("Please enter the year of the car:");
        }
    }
}
