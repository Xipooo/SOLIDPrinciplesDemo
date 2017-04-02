using SOLIDPrinciplesDemo.SRP.Services.CarValidationService;

namespace SOLIDPrinciplesDemo.SRP.Services.CarAcceptanceService
{
    interface CarAcceptanceService
    {
        string GetCarMake();
        string GetCarYear();
        bool ValidateCar(CarDetails Car, CarValidationRule ValidationRule);
    }
}
