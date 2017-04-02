using SOLIDPrinciplesDemo.SRP.Services.CarValidationService;
using System;

namespace SOLIDPrinciplesDemo.SRP.Services.CarAcceptanceService
{
    class SOLIDCarAcceptanceService : CarAcceptanceService
    {
        public string GetCarMake()
        {
            throw new NotImplementedException();
        }

        public string GetCarYear()
        {
            throw new NotImplementedException();
        }

        public bool ValidateCar(CarDetails Car, CarValidationRule ValidationRule)
        {
            throw new NotImplementedException();
        }
    }
}
