using SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt;
using SOLIDPrinciplesDemo.SRP.Features.ConvertCarYearToNumber;
using System;

namespace SOLIDPrinciplesDemo.SRP.Services.CarPromptService
{
    public class CarPromptService
    {
        public PromptForCarDetailsResult PromptForCarDetails() =>
            new PromptForCarDetailsResult
            {
                CarMake = new CarDetailsPrompt().GetCarMake(),
                CarYear = new CarDetailsPrompt().GetCarYear()
            };


        public CarYearValidationResult CarYearValidation(string carYear)
        {
            CarYearConverter carYearConverter = new CarYearConverter(carYear);
            if (!carYearConverter.Successful) return CarValidationFailedResultFailed(carYearConverter);

            if (carYear.Length != 2 && carYear.Length != 4)
            {

            }
        }

        private CarYearValidationResult CarValidationFailedResultFailed(CarYearConverter carYearConverter) =>
            new CarYearValidationResult
            {
                Successful = carYearConverter.Successful,
                FailureReason = carYearConverter.FailureReason
            };

    }
}
