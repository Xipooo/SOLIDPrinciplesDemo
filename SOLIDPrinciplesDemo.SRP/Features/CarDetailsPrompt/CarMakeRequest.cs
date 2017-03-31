using System;

namespace SOLIDPrinciplesDemo.SRP.Features.CarDetailsPrompt
{
    public class CarMakeRequest
    {
        public string result { get; set; }
        public CarMakeRequest()
        {
            Console.WriteLine(Environment.NewLine + "Please enter the make of the car:");
            result = Console.ReadLine();
        }
    }
}
