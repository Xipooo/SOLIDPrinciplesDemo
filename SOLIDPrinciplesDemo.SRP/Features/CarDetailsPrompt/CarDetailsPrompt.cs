namespace SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt
{
    public class CarDetailsPrompt
    {
        public string GetCarMake() => new CarMakeRequest().result;
        public string GetCarYear() => new CarYearRequest().result;
    }
}
