using SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt;
using SOLIDPrinciplesDemo.SRP.Features.ConvertCarYearToNumber;
using System;

namespace SOLIDPrinciplesDemo.SRP.Services
{
    public class CarPromptService
    {
        public void PromptForCarDetails() {
            var prompt = new CarDetailsPrompt();
            var carMake = prompt.GetCarMake();
            var carYear = prompt.GetCarYear();
        }

        public void CarYearValidation(string carYear)
        {
            CarYearConverter carYearConverter = new CarYearConverter(carYear);
            if (!carYearConverter.Successful) Console.WriteLine(carYearConverter.FailureReason);

        }

    }
}
