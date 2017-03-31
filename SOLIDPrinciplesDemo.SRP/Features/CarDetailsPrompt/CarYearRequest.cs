using System;

namespace SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt
{
    public class CarYearRequest
    {
        public string result { get; }
        public CarYearRequest()
        {
            Console.WriteLine("Please enter the year of the car:");
            result = Console.ReadLine();
        }
    }
}
