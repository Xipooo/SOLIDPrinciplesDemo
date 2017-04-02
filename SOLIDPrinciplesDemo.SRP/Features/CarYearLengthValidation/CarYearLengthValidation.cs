namespace SOLIDPrinciplesDemo.SRP.Features.CarYearLengthValidation
{
    public class CarYearLengthValidation
    {
        public bool Successful { get; }
        public string FailureReason { get; }

        public CarYearLengthValidation(string CarYear)
        {
            Successful = (CarYear.Length == 2 || CarYear.Length == 4);
            FailureReason = (Successful ? null : "Year entered is not 2 or 4 digits.");
        }
    }
}
