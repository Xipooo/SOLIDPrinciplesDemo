using SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt;
using SOLIDPrinciplesDemo.SRP.Features.CarYearLengthValidation;
using SOLIDPrinciplesDemo.SRP.Features.ConvertCarYearToNumber;

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

            CarYearLengthValidation carYearLengthValidation = new CarYearLengthValidation(carYear);
            if (!carYearLengthValidation.Successful) return CarValidationFailedResultFailed(carYearLengthValidation);
        }

        private CarYearValidationResult CarValidationFailedResultFailed(CarYearConverter carYearConverter) =>
            new CarYearValidationResult
            {
                Successful = carYearConverter.Successful,
                FailureReason = carYearConverter.FailureReason
            };

        private CarYearValidationResult CarValidationFailedResultFailed(CarYearLengthValidation carYearLengthValidation) =>
            new CarYearValidationResult
            {
                Successful = carYearLengthValidation.Successful,
                FailureReason = carYearLengthValidation.FailureReason
            };
    }
}
